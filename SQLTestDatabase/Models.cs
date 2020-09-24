using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQLTestDatabase
{
    class Models
    {
    }

    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            FechaCreacion = DateTime.Now;
            FechaModificacion = DateTime.Now;
        }
        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; private set; }
        [DataType(DataType.DateTime)]
        public DateTime? FechaModificacion { get; set; }
    }


    public class Empresa: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }


    }

    public class TipoVehiculo : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class Vehiculo : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Anio { get; set; }
        public string Placas { get; set; }
        public string Descripcion { get; set; }
        public long TipoVehiculoId { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }

    }




    public class TipoPersona : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }



    public class Persona: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string RFC { get; set; }
        public long? EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }


    }

    public class Pedido : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Numero { get; set; }
        public int CantidadProductos { get; set; }
        public int Descripcion { get; set; }

    }

    public class Viaje: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

    }

    public class ViajeChofer: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long ViajeId { get; set; }
        public virtual Viaje Viaje { get; set; }
        public long PersonaId { get; set; }
        public virtual Persona Persona { get; set; }
    }
    public class ViajeChoferPedido : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long ViajeId { get; set; }
        public virtual Viaje Viaje { get; set; }
        public long PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public string Estatus { get; set; }
        public string Descripcion { get; set; }


    }


    public class PedidoCte : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public long PersonaId { get; set; }
        public virtual Persona Persona { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }

    }







}
