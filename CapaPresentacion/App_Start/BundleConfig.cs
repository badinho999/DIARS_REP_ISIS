using System.Web.Optimization;

namespace CapaPresentacion
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
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
                "~/Bootstrap/styles/responsive.css"));

            bundles.Add(new StyleBundle("~/bundles/aboutcss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/parallax.css",
                "~/Bootstrap/styles/about.css",
                "~/Bootstrap/styles/about_responsive.css"));

            bundles.Add(new StyleBundle("~/bundles/roomscss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/rooms.css",
                "~/Bootstrap/styles/rooms_responsive.css"));

            bundles.Add(new StyleBundle("~/bundles/contactcss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/contact3.css",
                "~/Bootstrap/styles/contact_responsive.css"));

            bundles.Add(new StyleBundle("~/bundles/logincss")
                .Include(
                "~/Bootstrap/styles/bootstrap-4.1.2/bootstrap.min.css",
                "~/Bootstrap/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                "~/Bootstrap/plugins/OwlCarousel2-2.3.4/animate.css",
                "~/Bootstrap/plugins/jquery-datepicker/jquery-ui.css",
                "~/Bootstrap/styles/login.css",
                "~/Bootstrap/styles/parallax.css",
                "~/Bootstrap/styles/responsive.css"));

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
                "~/Bootstrap/js/custom.js"));
                                                                  
            bundles.Add(new ScriptBundle("~/bundles/aboutjs")
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
                "~/Bootstrap/js/about.js"));
                                   
            bundles.Add(new ScriptBundle("~/bundles/roomsjs")
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
                "~/Bootstrap/js/rooms.js"));

            bundles.Add(new ScriptBundle("~/bundles/contactjs")
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
                "~/Bootstrap/js/google-api.js",
                "~/Bootstrap/js/contact.js"));

            bundles.Add(new ScriptBundle("~/bundles/loginjs")
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
                "~/Bootstrap/js/login.js"));

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