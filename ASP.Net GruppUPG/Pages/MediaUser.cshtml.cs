using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Net_GruppUPG.Pages
{
    public class MediaUserModel : PageModel
    {
        private readonly MediaUserService _mediaUserService;

        public MediaUserModel(MediaUserService mediaUserService)
        {
            _mediaUserService = mediaUserService;
        }
        public List<MediaUser> MediaUsers { get; set; }

        [BindProperty]
        public MediaUser NewMediaUser { get; set; }

        public void OnGet()
        {
            MediaUsers = _mediaUserService.GetMediaUsers();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _mediaUserService.AddMediaUser(NewMediaUser);
                return RedirectToPage();
            }
            return Page();
        }

        public IActionResult OnPostDelete (int id)
        {
            var result = _mediaUserService.DeleteMediaUserById(id);
            if (!result)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
