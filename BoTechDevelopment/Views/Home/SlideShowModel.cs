using Microsoft.AspNetCore.Mvc.Razor;
namespace BoTechDevelopment.Views.Home
{

    public class _SlideShowModel : RazorPage<dynamic>
    {
        int img = 0;
        string[] imgPaths = { "/Images/Logos/BoTechLogoNew.png", "/Images/Logos/ISim.png", "/Images/Logos/abc.png" };
        void ShowNextImg()
        {
            img = img + 1;
            if (imgPaths.Length - 1 != img)
            {
                Show(img);
            }
            else
            {
                img = img - 1;
                Show(img);
            }
        }
        void ShowPreviousImg()
        {
            img = img - 1;
            if (img! < 0)
            {
                Show(img);
            }
            else
            {
                img = 0;
                Show(img);
            }
        }
        void Show(int img)
        {
            if (imgPaths[img] != null)
            {
                WriteLiteral(  "< img src = "@imgPaths[img]" />");
            }
        }
    }
}
