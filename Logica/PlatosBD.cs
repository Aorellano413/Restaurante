﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;
using Entidades;

namespace Logica
{
    public class PlatosBD
    {
        InventarioPlatos datos = new InventarioPlatos();

        public DataTable MostrarNuevaTabla()
        {
            return datos.MostrarNuevaTabla();
        }

        public DataTable BuscarInventarioPlatosNombre(string nombre)
        {
            return datos.BuscarInventarioPlatosPorNombre(nombre);
        }

        public void InsertarPlato(Plato plato)
        {
            datos.InsertarPlato(plato);
            List<PlatoIngrediente> ingredientes = plato.Ingredientes.Select(i => new PlatoIngrediente
            {
                IdIngrediente = i.Id,
                NombreIngrediente = i.Nombre,
                Cantidad = i.Stock
            }).ToList();
            datos.AsignarCantidadIngredientes(plato.Id, ingredientes);
        }

        public List<Ingrediente> ObtenerIngredientes()
        {
            return datos.ObtenerIngredientes();
        }

        public void ModificarPlato(Plato plato)
        {
            datos.ModificarPlato(plato);
            // Actualiza las cantidades de ingredientes en INGREDIENTES_PLATOS
            List<PlatoIngrediente> ingredientes = plato.Ingredientes.Select(i => new PlatoIngrediente
            {
                IdIngrediente = i.Id,
                NombreIngrediente = i.Nombre,
                Cantidad = i.Stock
            }).ToList();
            datos.AsignarCantidadIngredientes(plato.Id, ingredientes);
        }

        public void EliminarPlato(int idPlato)
        {
            datos.EliminarPlato(idPlato);
        }

        public List<PlatoIngrediente> ObtenerIngredientesDePlato(int idPlato)
        {
            return datos.ObtenerIngredientesDePlato(idPlato);
        }

        public void AsignarCantidadIngredientes(int idPlato, List<PlatoIngrediente> ingredientes)
        {
            datos.AsignarCantidadIngredientes(idPlato, ingredientes);
        }

        public Plato ObtenerPlatoPorId(int idPlato)
        {
            return datos.ObtenerPlatoPorId(idPlato);
        }

        public void EliminarIngredienteYActualizarPlatos(int idIngrediente)
        {
            datos.EliminarIngredienteYActualizarPlatos(idIngrediente);
        }

        //MENU PEDIDO
        public List<Plato> ObtenerTodosLosPlatos()
        {
            return datos.ObtenerTodosLosPlatos();
        }

    }
}
