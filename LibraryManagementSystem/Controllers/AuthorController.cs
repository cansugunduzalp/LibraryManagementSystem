using Microsoft.AspNetCore.Mvc;

public class AuthorController : Controller
{
    private static List<Author> _authors = new List<Author>();

    public IActionResult List()
    {
        var authorViewModels = _authors.Select(a => new AuthorViewModel
        {
            Id = a.Id,
            FullName = a.FirstName + " " + a.LastName,
            DateOfBirth = a.DateOfBirth
        }).ToList();

        return View(authorViewModels);
    }

    public IActionResult Details(int id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author == null)
        {
            return NotFound();
        }

        var authorViewModel = new AuthorViewModel
        {
            Id = author.Id,
            FullName = author.FirstName + " " + author.LastName,
            DateOfBirth = author.DateOfBirth
        };

        return View(authorViewModel);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Author author)
    {
        author.Id = _authors.Count + 1;
        _authors.Add(author);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author == null)
        {
            return NotFound();
        }

        return View(author);
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        var existingAuthor = _authors.FirstOrDefault(a => a.Id == author.Id);
        if (existingAuthor == null)
        {
            return NotFound();
        }

        existingAuthor.FirstName = author.FirstName;
        existingAuthor.LastName = author.LastName;
        existingAuthor.DateOfBirth = author.DateOfBirth;

        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author == null)
        {
            return NotFound();
        }

        return View(author);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author != null)
        {
            _authors.Remove(author);
        }

        return RedirectToAction("List");
    }
}