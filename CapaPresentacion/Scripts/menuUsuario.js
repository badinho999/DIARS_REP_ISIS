$("a#idLogin").remove();
$("#userInfo").append(`
            <div class="top_nav d-flex flex-column align-items-end justify-content-lg-end justify-content-end">
                <div class="nav_menu">
                    <nav>
                        <ul class="nav navbar-nav navbar-right">
                            <li class="">
                                <a href="#" data-toggle="dropdown" aria-expanded="false">
                                    <img src="~/Bootstrap/images/author_1.jpg" alt=""> Usuario
                                    <span class=" fa fa-angle-down"></span>
                                </a>
                                <ul class="dropdown-menu dropdown-usermenu pull-right">
                                    <li><a href="#"> Perfil</a></li>
                                    <li><a href="#"> Mis Reservas</a></li>
                                    <li><a href="#"><i class="fa fa-sign-out pull-right"></i> Cerrar Sesión</a></li>
                                </ul>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        `)