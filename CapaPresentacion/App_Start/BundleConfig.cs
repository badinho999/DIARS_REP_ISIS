using System.Web.Optimization;

namespace CapaPresentacion
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                "~/Scripts/signUp.js",
                "~/Scripts/logIn.js",
                "~/Bootstrap-datetime/js/bootstrap-datepicker.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/main_styles.css",
                "~/Bootstrap/styles/parallax.css",
                "~/Bootstrap/styles/responsive.css",
                "~/Bootstrap-datetime/css/bootstrap-datepicker.css",
                 "~/Bootstrap/styles/multi-select.css"));

            bundles.Add(new StyleBundle("~/bundles/mantenedorescss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/mantenedores.css",
                "~/Bootstrap/styles/parallax.css",
                "~/Bootstrap/styles/responsive.css",
                "~/Bootstrap/styles/multi-select.css"));

            bundles.Add(new StyleBundle("~/bundles/reservarcss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/reservar.css",
                "~/Bootstrap/styles/parallax.css",
                "~/Bootstrap/styles/responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Bootstrap/js/jquery-3.3.1.min.js",
                "~/Bootstrap/styles/bootstrap-4.1.2/popper.js",
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.js",
                "~/Bootstrap/plugins/greensock/TweenMax.min.js",
                "~/Bootstrap/plugins/greensock/TimelineMax.min.js",
                "~/Bootstrap/plugins/scrollmagic/ScrollMagic.min.js",
                "~/Bootstrap/plugins/greensock/animation.gsap.min.js",
                "~/Bootstrap/plugins/greensock/ScrollToPlugin.min.js",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.js",
                "~/Bootstrap/plugins/easing/easing.js",
                "~/Bootstrap/plugins/progressbar/progressbar.min.js",
                "~/Bootstrap/plugins/parallax-js-master/parallax.min.js",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.js",
                "~/Bootstrap/js/custom.js",
                "~/Bootstrap/js/about.js",
                "~/Bootstrap/js/rooms.js",
                "~/Bootstrap/js/google-api.js",
                "~/Bootstrap/js/contact.js"));

            bundles.Add(new ScriptBundle("~/bundles/mantenedoresjs")
                .Include(
                "~/Bootstrap/js/jquery-3.3.1.min.js",
                "~/Bootstrap/styles/bootstrap-4.1.2/popper.js",
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.js",
                "~/Bootstrap/plugins/greensock/TweenMax.min.js",
                "~/Bootstrap/plugins/greensock/TimelineMax.min.js",
                "~/Bootstrap/plugins/scrollmagic/ScrollMagic.min.js",
                "~/Bootstrap/plugins/greensock/animation.gsap.min.js",
                "~/Bootstrap/plugins/greensock/ScrollToPlugin.min.js",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.js",
                "~/Bootstrap/plugins/easing/easing.js",
                "~/Bootstrap/plugins/progressbar/progressbar.min.js",
                "~/Bootstrap/plugins/parallax-js-master/parallax.min.js",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.js",
                "~/Bootstrap/js/custom.js",
                "~/Bootstrap/js/jquery.multi-select.js"));
        }
    }
}