using LibraryManagementSystem.Models.ViewModels;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

public class BookController : Controller
{
    // Kitapların listesini tutan statik örnek veri (gerçek veri tabanına bağlanacak)
    private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "C Sharp Basics", AuthorId = 1, Genre = "Programming", PublishDate = DateTime.Parse("2021-01-01"), ISBN = "1234567890", CopiesAvailable = 10 },
        new Book { Id = 2, Title = "ASP.NET Core", AuthorId = 2, Genre = "Web Development", PublishDate = DateTime.Parse("2020-06-01"), ISBN = "0987654321", CopiesAvailable = 5 }
    };

    // Kitapların listesini kullanıcıya gösteren action metodu
    public IActionResult List()
    {
        // Kitap bilgilerini viewmodel'e dönüştürme
        var bookViewModels = books.Select(b => new BookViewModel
        {
            Id = b.Id,
            Title = b.Title,
            AuthorFullName = "Author Name", // Yazarın adını Author modelinden alabilirsiniz
            Genre = b.Genre,
            PublishDate = b.PublishDate,
            ISBN = b.ISBN,
            CopiesAvailable = b.CopiesAvailable
        }).ToList();

        // Kitapların listelendiği View'a veri gönderme
        return View(bookViewModels);
    }

    // Kitap detaylarını gösteren action metodu
    public IActionResult Details(int id)
    {
        // Kitap ID'sine göre kitap bulma
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound(); // Eğer kitap bulunamazsa hata döndürülür

        // Kitap detaylarını view model formatında döndürme
        var bookViewModel = new BookViewModel
        {
            Id = book.Id,
            Title = book.Title,
            AuthorFullName = "Author Name", // Yazar adını burada alabilirsiniz
            Genre = book.Genre,
            PublishDate = book.PublishDate,
            ISBN = book.ISBN,
            CopiesAvailable = book.CopiesAvailable
        };

        return View(bookViewModel); // Detayları gösteren view'a veri gönderme
    }

    // Kitap eklemek için form sağlayan action metodu
    public IActionResult Create()
    {
        return View(); // Kullanıcıya kitap ekleme formunu gösterir
    }

    // Kitap ekleme işlemini gerçekleştiren action metodu
    [HttpPost]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid) // Model geçerliyse, kitap eklenir
        {
            books.Add(book); // Kitap listeye eklenir
            return RedirectToAction(nameof(List)); // Liste sayfasına yönlendirilir
        }
        return View(book); // Hata varsa form tekrar gösterilir
    }

    // Kitap düzenleme sayfasına yönlendiren action metodu
    public IActionResult Edit(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound(); // Eğer kitap bulunmazsa hata döndürülür

        return View(book); // Kitap bilgileriyle düzenleme formunu gösterir
    }

    // Kitap düzenleme işlemini gerçekleştiren action metodu
    [HttpPost]
    public IActionResult Edit(Book book)
    {
        if (ModelState.IsValid) // Model geçerliyse, kitap düzenlenir
        {
            var existingBook = books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.AuthorId = book.AuthorId;
                existingBook.Genre = book.Genre;
                existingBook.PublishDate = book.PublishDate;
                existingBook.ISBN = book.ISBN;
                existingBook.CopiesAvailable = book.CopiesAvailable;
            }
            return RedirectToAction(nameof(List)); // Düzenleme sonrası listeye yönlendirilir
        }
        return View(book); // Hata varsa form tekrar gösterilir
    }

    // Kitap silme sayfasına yönlendiren action metodu
    public IActionResult Delete(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound(); // Kitap bulunmazsa hata döndürülür

        return View(book); // Silme onayı sayfası gösterilir
    }

    // Kitap silme işlemini gerçekleştiren action metodu
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            books.Remove(book); // Kitap listeden silinir
        }
        return RedirectToAction(nameof(List)); // Silme işleminden sonra kitap listesine yönlendirilir
    }
}
