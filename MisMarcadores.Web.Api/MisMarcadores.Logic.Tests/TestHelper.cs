﻿using MisMarcadores.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisMarcadores.Logic.Tests
{
    public class TestHelper
    {
        public static Usuario ObtenerUsuarioFalso()
        {
            List<Usuario> usuarios = ObtenerUsuariosFalsos().ToList();
            return usuarios.FirstOrDefault();
        }

        public static Deporte ObtenerDeporteFalso()
        {
            List<Deporte> deportes = ObtenerDeportesFalsos().ToList();
            return deportes.FirstOrDefault();
        }

        public static Equipo ObtenerEquipoFalso()
        {
            List<Equipo> equipos = ObtenerEquiposFalsos().ToList();
            return equipos.FirstOrDefault();
        }

        public static Encuentro ObtenerEncuentroFalso()
        {
            List<Encuentro> encuentros = ObtenerEncuentrosFalsos().ToList();
            return encuentros.FirstOrDefault();
        }

        public static Encuentro ObtenerNuevoEncuentroFalso()
        {
            return new Encuentro
            {
                Id = Guid.NewGuid(),
                FechaHora = DateTime.Today.AddDays(5),
                EquipoLocal = new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Defensor",
                    Foto = "",
                    Deporte = new Deporte { Nombre = "Futbol" }
                },
                EquipoVisitante = new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Danubio",
                    Foto = "",
                    Deporte = new Deporte { Nombre = "Futbol" }
                },
                Deporte = new Deporte { Nombre = "Futbol" }
            };
        }

        public static List<Usuario> ObtenerUsuariosFalsos()
        {
            return new List<Usuario>
            {
                new Usuario
                {
                    Nombre = "Andres",
                    Apellido = "Correa",
                    NombreUsuario = "acorrea",
                    Contraseña = "acorrea123",
                    Mail = "acorrea@gmail.com",
                    Administrador = true,
                },
                new Usuario
                {
                    Nombre = "Jorge",
                    Apellido = "Perez",
                    NombreUsuario = "jperez",
                    Contraseña = "jperez123",
                    Mail = "jperez@gmail.com",
                    Administrador = true,
                },
                new Usuario
                {
                    Nombre = "Carlos",
                    Apellido = "Gutierrez",
                    NombreUsuario = "cguti",
                    Contraseña = "cguti1234",
                    Mail = "cgutierrez@gmail.com",
                    Administrador = false,
                }
            };
        }

        public static Usuario ObtenerUsuarioMailFormatoErroneo()
        {
            return new Usuario
            {
                Nombre = "Andres",
                Apellido = "Correa",
                NombreUsuario = "acorrea",
                Contraseña = "acorrea123",
                Mail = "abcd",
                Administrador = true,
            };
        }

        public static Usuario ObtenerUsuarioNombreVacio()
        {
            return new Usuario
            {
                Nombre = "",
                Apellido = "Correa",
                NombreUsuario = "acorrea",
                Contraseña = "acorrea123",
                Mail = "abcd@gmail.com",
                Administrador = true,
            };
        }

        public static Usuario ObtenerUsuarioApellidoVacio()
        {
            return new Usuario
            {
                Nombre = "Andres",
                Apellido = "",
                NombreUsuario = "acorrea",
                Contraseña = "acorrea123",
                Mail = "abcd@gmail.com",
                Administrador = true,
            };
        }

        public static Usuario ObtenerUsuarioContraseñaVacia()
        {
            return new Usuario
            {
                Nombre = "Andres",
                Apellido = "Correa",
                NombreUsuario = "acorrea",
                Contraseña = "",
                Mail = "abcd@gmail.com",
                Administrador = true,
            };
        }

        public static Usuario ObtenerUsuarioNombreUsuarioVacio()
        {
            return new Usuario
            {
                Nombre = "Andres",
                Apellido = "Correa",
                NombreUsuario = "",
                Contraseña = "",
                Mail = "abcd@gmail.com",
                Administrador = true,
            };
        }

        public static Sesion ObtenerSesionFalsa()
        {
            return new Sesion
            {
                NombreUsuario = "acorrea",
                Token = Guid.NewGuid()
            };
        }

        public static List<Deporte> ObtenerDeportesFalsos()
        {
            return new List<Deporte>
            {
                new Deporte
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Futbol"
                },
                new Deporte
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Basket"
                },
                new Deporte
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Tenis"
                }
            };
        }

        public static Deporte ObtenerDeporteNombreVacio()
        {
            return new Deporte
            {
                Id = Guid.NewGuid(),
                Nombre = "",
            };
        }

        public static List<Equipo> ObtenerEquiposFalsos()
        {
            return new List<Equipo>
            {
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Defensor",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Futbol"}
                },
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Capitol",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Basket"}
                },
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Atenas",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Basket"}
                },
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Liverpool",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Futbol"}
                },
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Miramar",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Futbol"}
                },
                new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Champagnat",
                    Foto = "",
                    Deporte = new Deporte {Nombre = "Rugby"}
                },
            };
        }

        public static Equipo ObtenerEquipoNombreVacio()
        {
            return new Equipo
            {
                Nombre = "",
                Foto = "",
                Deporte = new Deporte { Nombre = "Rugby" }
            };
        }
        public static List<Encuentro> ObtenerEncuentrosFalsos()
        {
            return new List<Encuentro>
            {
                new Encuentro
                {
                    Id = Guid.NewGuid(),
                    FechaHora = DateTime.Today,
                    EquipoLocal = new Equipo
                        {
                            Id = Guid.NewGuid(),
                            Nombre = "Capitol",
                            Foto = "",
                            Deporte = new Deporte {Nombre = "Basket"}
                        },
                    EquipoVisitante = new Equipo
                        {
                            Id = Guid.NewGuid(),
                            Nombre = "Atenas",
                            Foto = "",
                            Deporte = new Deporte {Nombre = "Basket"}
                        },
                    Deporte = new Deporte {Nombre = "Basket"}
                },
                new Encuentro
                {
                    Id = Guid.NewGuid(),
                    FechaHora = DateTime.Today,
                    EquipoLocal = new Equipo
                        {
                            Id = Guid.NewGuid(),
                            Nombre = "Defensor",
                            Foto = "",
                            Deporte = new Deporte {Nombre = "Futbol"}
                        },
                    EquipoVisitante = new Equipo
                        {
                            Id = Guid.NewGuid(),
                            Nombre = "Danubio",
                            Foto = "",
                            Deporte = new Deporte {Nombre = "Futbol"}
                        },
                    Deporte = new Deporte {Nombre = "Futbol"}
                }
            };
        }

        public static Encuentro ObtenerEncuentroEquipoNombreVacio()
        {
            return new Encuentro
            {
                Id = Guid.NewGuid(),
                FechaHora = DateTime.Today,
                EquipoLocal = new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "",
                    Foto = "",
                    Deporte = new Deporte { Nombre = "Basket" }
                },
                EquipoVisitante = new Equipo
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Atenas",
                    Foto = "",
                    Deporte = new Deporte { Nombre = "Basket" }
                },
                Deporte = new Deporte { Nombre = "Basket" }
            };
        }
    }
}
