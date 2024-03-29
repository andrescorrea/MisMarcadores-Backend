﻿using MisMarcadores.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MisMarcadores.Repository
{
    public interface IEquiposRepository : IGenericRepository<Equipo>
    {
        Equipo ObtenerEquipoPorId(Guid id);
        Equipo ObtenerEquipoPorNombre(String nombre);
        Equipo ObtenerEquipoPorDeporte(String nombreDeporte, String nombreEquipo);
        void ModificarEquipo(Equipo equipo);
        void BorrarEquipo(Guid id);
        List<Equipo> ObtenerEquipos();
        List<Equipo> ObtenerEquiposPorDeporte(String deporte);
    }
}
