using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebVentas.Models
{
    public partial class VENTASContext : DbContext
    {
        public VENTASContext()
        {
        }

        public VENTASContext(DbContextOptions<VENTASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabecera> Cabeceras { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Detalle> Detalles { get; set; }
        public virtual DbSet<Familia> Familias { get; set; }
        public virtual DbSet<GuiaRemision> GuiaRemisions { get; set; }
        public virtual DbSet<Linea> Lineas { get; set; }
        public virtual DbSet<Medida> Medidas { get; set; }
        public virtual DbSet<ModalidadTransporte> ModalidadTransportes { get; set; }
        public virtual DbSet<ModalidadTransporte1> ModalidadTransportes1 { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<Nubefact> Nubefacts { get; set; }
        public virtual DbSet<NubefactError> NubefactErrors { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<SMenu> SMenus { get; set; }
        public virtual DbSet<SRole> SRoles { get; set; }
        public virtual DbSet<SRolesUser> SRolesUsers { get; set; }
        public virtual DbSet<SunatAdicionalesCabecera> SunatAdicionalesCabeceras { get; set; }
        public virtual DbSet<SunatAdicionalesDetalle> SunatAdicionalesDetalles { get; set; }
        public virtual DbSet<SunatCodProducto> SunatCodProductos { get; set; }
        public virtual DbSet<SunatComunicacionBaja> SunatComunicacionBajas { get; set; }
        public virtual DbSet<SunatDocumentorelacionado> SunatDocumentorelacionados { get; set; }
        public virtual DbSet<SunatLeyendum> SunatLeyenda { get; set; }
        public virtual DbSet<SunatPercepcionCabecera> SunatPercepcionCabeceras { get; set; }
        public virtual DbSet<SunatPercepcionDetalle> SunatPercepcionDetalles { get; set; }
        public virtual DbSet<SunatResumenDiario> SunatResumenDiarios { get; set; }
        public virtual DbSet<SunatResumenReversion> SunatResumenReversions { get; set; }
        public virtual DbSet<SunatRetencionCabecera> SunatRetencionCabeceras { get; set; }
        public virtual DbSet<SunatRetencionDetalle> SunatRetencionDetalles { get; set; }
        public virtual DbSet<SunatTipoComprobante> SunatTipoComprobantes { get; set; }
        public virtual DbSet<SunatTipoDocumento> SunatTipoDocumentos { get; set; }
        public virtual DbSet<SunatTipoMercaderia> SunatTipoMercaderias { get; set; }
        public virtual DbSet<SunatTributosGenerale> SunatTributosGenerales { get; set; }
        public virtual DbSet<SunatUnidadMedida> SunatUnidadMedidas { get; set; }
        public virtual DbSet<TblPerfil> TblPerfils { get; set; }
        public virtual DbSet<TblRegla> TblReglas { get; set; }
        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }
        public virtual DbSet<TipoAfectacionIgv> TipoAfectacionIgvs { get; set; }
        public virtual DbSet<Tipocambio> Tipocambios { get; set; }
        public virtual DbSet<Tipocomprobante> Tipocomprobantes { get; set; }
        public virtual DbSet<Tipodoc> Tipodocs { get; set; }
        public virtual DbSet<TipodocParte> TipodocPartes { get; set; }
        public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }
        public virtual DbSet<Tipomovimiento> Tipomovimientos { get; set; }
        public virtual DbSet<Tiposnotascredito> Tiposnotascreditos { get; set; }
        public virtual DbSet<Tiposnotasdebito> Tiposnotasdebitos { get; set; }
        public virtual DbSet<TotalValorizado> TotalValorizados { get; set; }
        public virtual DbSet<TransPerfilRegla> TransPerfilReglas { get; set; }
        public virtual DbSet<Transporte> Transportes { get; set; }
        public virtual DbSet<Transportista> Transportistas { get; set; }
        public virtual DbSet<Traslado> Traslados { get; set; }
        public virtual DbSet<Ubigeo> Ubigeos { get; set; }
        public virtual DbSet<Ubigeo1> Ubigeos1 { get; set; }
        //nuevo modelo
        public virtual DbSet<PedidosFecha> PedidosPorFecha { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=VENTAS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabecera>(entity =>
            {
                entity.HasKey(e => e.Idcabecera)
                    .HasName("PK_CUE00001");

                entity.ToTable("CABECERA");

                entity.Property(e => e.Idcabecera).HasColumnName("IDCABECERA");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Chser).HasColumnName("CHSER");

                entity.Property(e => e.Dscto)
                    .HasColumnType("money")
                    .HasColumnName("DSCTO");

                entity.Property(e => e.FechaEmiRef).HasColumnType("date");

                entity.Property(e => e.Fechaemision)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAEMISION");

                entity.Property(e => e.Fechavencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAVENCIMIENTO");

                entity.Property(e => e.Guiaremision)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GUIAREMISION");

                entity.Property(e => e.IdTipoNotaCredito)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoNotaDebito)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

                entity.Property(e => e.Idmoneda)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IDMONEDA");

                entity.Property(e => e.Idtipocomp).HasColumnName("IDTIPOCOMP");

                entity.Property(e => e.Igv)
                    .HasColumnType("money")
                    .HasColumnName("IGV");

                entity.Property(e => e.Incligv).HasColumnName("INCLIGV");

                entity.Property(e => e.NumDocRef)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Numdoc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMDOC");

                entity.Property(e => e.Numero)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Porcigv)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PORCIGV");

                entity.Property(e => e.Serie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SERIE");

                entity.Property(e => e.SerieDocRef)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TCompra)
                    .HasColumnType("money")
                    .HasColumnName("T_COMPRA");

                entity.Property(e => e.TipoDocRef)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TotDsctos)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_DSCTOS");

                entity.Property(e => e.TotIcbper)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_ICBPER");

                entity.Property(e => e.TotIgv)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_IGV");

                entity.Property(e => e.TotIsc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_ISC");

                entity.Property(e => e.TotNeto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_NETO");

                entity.Property(e => e.TotOtros)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_OTROS");

                entity.Property(e => e.TotSubtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_SUBTOTAL");

                entity.Property(e => e.TotTotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOT_TOTAL");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.Idcliente)
                    .HasConstraintName("FK_CABECERA_CLIENTES");

                entity.HasOne(d => d.IdmonedaNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.Idmoneda)
                    .HasConstraintName("FK_CABECERA_MONEDAS");

                entity.HasOne(d => d.IdtipocompNavigation)
                    .WithMany(p => p.Cabeceras)
                    .HasForeignKey(d => d.Idtipocomp)
                    .HasConstraintName("FK_CABECERA_SUNAT_TipoComprobante");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("CLIENTES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IdTipoDoc).HasMaxLength(1);

                entity.Property(e => e.NombApe).HasMaxLength(100);

                entity.Property(e => e.NombCom).HasMaxLength(100);

                entity.Property(e => e.NumDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UbigeoDireccion)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdTipoDocNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDoc)
                    .HasConstraintName("FK_CLIENTES_SUNAT_TipoDocumentos");

                entity.HasOne(d => d.IdTipoDoc1)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoDoc)
                    .HasConstraintName("FK_CLIENTES_TIPODOCUMENTOS");
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.HasKey(e => new { e.Idcab, e.Codcom })
                    .HasName("PK_SAL00001");

                entity.ToTable("DETALLES");

                entity.Property(e => e.Idcab).HasColumnName("IDCAB");

                entity.Property(e => e.Codcom)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CODCOM");

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CANTIDAD");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DESCUENTO");

                entity.Property(e => e.Igv)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IGV");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasColumnName("PRECIO");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .HasColumnName("USUARIO");

                entity.HasOne(d => d.CodcomNavigation)
                    .WithMany(p => p.Detalles)
                    .HasPrincipalKey(p => p.Codcom)
                    .HasForeignKey(d => d.Codcom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALLES_PRODUCTOS");

                entity.HasOne(d => d.IdcabNavigation)
                    .WithMany(p => p.Detalles)
                    .HasForeignKey(d => d.Idcab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALLES_CABECERA");
            });

            modelBuilder.Entity<Familia>(entity =>
            {
                entity.ToTable("FAMILIAS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre).HasMaxLength(150);
            });

            modelBuilder.Entity<GuiaRemision>(entity =>
            {
                entity.ToTable("GUIA_REMISION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brevete)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodPuertoEmbDes)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Despachador).HasMaxLength(50);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaInicioTraslado).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.GuiaPorte)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdTransportista).HasColumnName("idTransportista");

                entity.Property(e => e.Idcomprobante).HasColumnName("IDCOMPROBANTE");

                entity.Property(e => e.IndicaMotivoTraslado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LicenciaConducir)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Llegada).HasMaxLength(250);

                entity.Property(e => e.MotivoTraslado)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MovilTraslado).HasMaxLength(500);

                entity.Property(e => e.NumBultosPallets).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NumContenedor)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocConductor)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocDestinatario)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocProveedor)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocRelacionado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocRemite)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumGuiaRemisionBaja)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumRucTransportista)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroGuiaRemision)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSalida)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Partida).HasMaxLength(250);

                entity.Property(e => e.Peso).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Placa)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialConductor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialDestinatario).HasMaxLength(180);

                entity.Property(e => e.RazonSocialProveedor).HasMaxLength(180);

                entity.Property(e => e.RazonSocialRemite).HasMaxLength(180);

                entity.Property(e => e.RazonSocialTransportista).HasMaxLength(250);

                entity.Property(e => e.Serie)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SERIE");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocConductor).HasMaxLength(5);

                entity.Property(e => e.TipoDocDestinatario)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocGuiaRemBaja)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocProveedor)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocRelacionado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocRemite)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocTransportista)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTransporte)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tipoTransporte");

                entity.Property(e => e.UbigeoPuntoLlegada)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UbigeoPuntoPartida)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UniMedPesoBruto)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Linea>(entity =>
            {
                entity.ToTable("LINEAS");

                entity.Property(e => e.Linea1)
                    .HasMaxLength(150)
                    .HasColumnName("Linea");
            });

            modelBuilder.Entity<Medida>(entity =>
            {
                entity.ToTable("MEDIDAS");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<ModalidadTransporte>(entity =>
            {
                entity.ToTable("MODALIDAD_TRANSPORTE");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<ModalidadTransporte1>(entity =>
            {
                entity.ToTable("ModalidadTransporte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasMaxLength(250);
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MONEDAS_1");

                entity.ToTable("MONEDAS");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripción)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCIÓN");
            });

            modelBuilder.Entity<Nubefact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NUBEFACT");

                entity.Property(e => e.AceptadaPorSunat).HasColumnName("aceptada_por_sunat");

                entity.Property(e => e.CadenaParaCodigoQr)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cadena_para_codigo_qr");

                entity.Property(e => e.CdrZipBase64)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdr_zip_base64");

                entity.Property(e => e.CodigoHash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo_hash");

                entity.Property(e => e.Enlace)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("enlace");

                entity.Property(e => e.EnlaceDelCdr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("enlace_del_cdr");

                entity.Property(e => e.EnlaceDelPdf)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("enlace_del_pdf");

                entity.Property(e => e.EnlaceDelXml)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("enlace_del_xml");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.NumeroRegistro).HasColumnName("numero_registro");

                entity.Property(e => e.PdfZipBase64)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pdf_zip_base64");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("serie");

                entity.Property(e => e.SunatDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sunat_description");

                entity.Property(e => e.SunatNote)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sunat_note");

                entity.Property(e => e.SunatResponsecode)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sunat_responsecode");

                entity.Property(e => e.SunatSoapError)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sunat_soap_error");

                entity.Property(e => e.TipoDeComprobante)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("tipo_de_comprobante")
                    .IsFixedLength(true);

                entity.Property(e => e.XmlZipBase64)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("xml_zip_base64");
            });

            modelBuilder.Entity<NubefactError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NUBEFACT_ERROR");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Errors)
                    .HasMaxLength(500)
                    .HasColumnName("errors");

                entity.Property(e => e.NumeroRegistro).HasColumnName("numero_registro");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.ToTable("PARAMETROS");

                entity.Property(e => e.Categoria).HasMaxLength(150);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.Valor).HasMaxLength(500);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdArt);

                entity.ToTable("PRODUCTOS");

                entity.HasIndex(e => e.Detalle, "ALM_IDX");

                entity.HasIndex(e => e.Codcom, "ALM_IDX2");

                entity.HasIndex(e => e.Detalle, "IDX_DETALLE");

                entity.HasIndex(e => e.Codcom, "idxCodCom")
                    .IsUnique();

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CodSunat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CodSUNAT");

                entity.Property(e => e.Codcom)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("codcom");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(100)
                    .HasColumnName("detalle");

                entity.Property(e => e.IdLinea).HasColumnName("idLinea");

                entity.Property(e => e.IdTipMer)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("idTipMer");

                entity.Property(e => e.Idmedida)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Pmayor)
                    .HasColumnType("money")
                    .HasColumnName("pmayor");

                entity.Property(e => e.Stock)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("stock");

                entity.HasOne(d => d.IdTipMerNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdTipMer)
                    .HasConstraintName("FK_PRODUCTOS_SUNAT_TipoMercaderias");

                entity.HasOne(d => d.IdmedidaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Idmedida)
                    .HasConstraintName("FK_PRODUCTOS_SUNAT_UnidadMedidas");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProv)
                    .HasName("PK_ALMACEN");

                entity.ToTable("PROVEEDORES");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("contacto");

                entity.Property(e => e.Cta)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("cta");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Giro)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("giro");

                entity.Property(e => e.Mail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("proveedor");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ruc");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<SMenu>(entity =>
            {
                entity.ToTable("s_Menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enable)
                    .HasColumnName("enable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Menuid)
                    .HasMaxLength(50)
                    .HasColumnName("menuid");

                entity.Property(e => e.Menuname)
                    .HasMaxLength(50)
                    .HasColumnName("menuname");

                entity.Property(e => e.Menuparent)
                    .HasMaxLength(50)
                    .HasColumnName("menuparent");

                entity.Property(e => e.Role)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("role")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SRole>(entity =>
            {
                entity.ToTable("s_Roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rol)
                    .HasMaxLength(50)
                    .HasColumnName("rol");
            });

            modelBuilder.Entity<SRolesUser>(entity =>
            {
                entity.HasKey(e => new { e.IdRol, e.Idusuario })
                    .HasName("PK_Roles_Users");

                entity.ToTable("s_Roles_Users");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.SRolesUsers)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_Roles_Users_s_Roles");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.SRolesUsers)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_s_Roles_Users_tblUsuario");
            });

            modelBuilder.Entity<SunatAdicionalesCabecera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_AdicionalesCabecera");

                entity.Property(e => e.CodBienDetraccion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaisCliente)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaisEntrega)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbigeoCliente)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodUbigeoEntrega)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBancoNacionDetraccion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionEntrega)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MontoDetraccion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeDetraccion)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatAdicionalesDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_AdicionalesDetalle");

                entity.Property(e => e.CodConceptoItem)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPropiedad)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LineaItem)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePropiedad)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValorPropiedad)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatCodProducto>(entity =>
            {
                entity.HasKey(e => e.Codsunat);

                entity.ToTable("SUNAT_CodProductos");

                entity.Property(e => e.Codsunat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codsunat");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .HasColumnName("detalle");
            });

            modelBuilder.Entity<SunatComunicacionBaja>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_ComunicacionBaja");

                entity.Property(e => e.DesMotivoBaja)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desMotivoBaja");

                entity.Property(e => e.FecComunicacion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecComunicacion");

                entity.Property(e => e.FecGeneracion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecGeneracion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NumDocBaja)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("numDocBaja");

                entity.Property(e => e.TipDocBaja)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tipDocBaja");
            });

            modelBuilder.Entity<SunatDocumentorelacionado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_Documentorelacionado");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indicador)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Monto)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocEmisor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificadorAnticipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocEmisor)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatLeyendum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_Leyenda");

                entity.Property(e => e.CodLeyenda)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLeyenda)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SunatPercepcionCabecera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_PercepcionCabecera");

                entity.Property(e => e.CodMonedaPercepcion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaisReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DistritoReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreComercialReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocIdentidadReceptor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegimenPercepcion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TasaPercepcion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocIdentidadReceptor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaTotalPagadoPercepcion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPagadoPercepcion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPercepcion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UbigeoReceptor)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanizacionReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatPercepcionDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_PercepcionDetalle");

                entity.Property(e => e.FactorTipoCambio)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmisionDocRelacionado)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPago)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPercepcion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTipoCambio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportePago)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImportePercibido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteTotalPagarNeto)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaImportePercibido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocRelacionado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPago)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TasaTipoCambio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocRelacionado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaDocRelacionado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaImporteTotalPagarNeto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaPago)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaRefTipoCambio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDocRelacionado)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatResumenDiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_ResumenDiario");

                entity.Property(e => e.BasePercepcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaResumen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImporteTotalSumatoria)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteTotalVenta)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MontoPercepcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTotalIncluidaPercepcion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCorrelativoBoleta)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerieBoletaModifica)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajePercepcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegimenPercepcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SerieNumeroDocResumen)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocModifica)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocResumen)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEstado)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMoneda)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOtrosTributos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalTribIgv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TotalTribIGV");

                entity.Property(e => e.TotalTribIsc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TotalTribISC");

                entity.Property(e => e.TotalValorExonerado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalValorGratuito)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalValorGravado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalValorInafecto)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatResumenReversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_ResumenReversion");

                entity.Property(e => e.DescripcionMotivoBaja)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaComunicacion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaGeneracion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NumeroDocBaja)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocBaja)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatRetencionCabecera>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_RetencionCabecera");

                entity.Property(e => e.CodPaisReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegimenRetencion)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DistritoReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImporteTotalPagadoRetencion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteTotalRetencion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaImporteTotalPagadoRetencion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaImporteTotalRetencion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NombreComReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocIdeReceptor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesRetencion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinciaReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TasaRetencion)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocIdeReceptor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UbigeoReceptor)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UrbanizacionReceptor)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatRetencionDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_RetencionDetalle");

                entity.Property(e => e.FactorTipoCambio)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmiDocRelacionado)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPago)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRetencion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTipoCambio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportePago)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteRetenido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteTotalDocRelacionado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaImporteRetenido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaTotalPagarNeto)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocRelacionado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPago)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TasaTipoCambio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocRelacionado)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaDocRelacionado)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaPago)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMonedaRefTipoCambio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPagarNeto)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatTipoComprobante>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_SUNAT_TipoComprobante_1");

                entity.ToTable("SUNAT_TipoComprobante");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<SunatTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("SUNAT_TipoDocumentos");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(1)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<SunatTipoMercaderia>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("SUNAT_TipoMercaderias");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<SunatTributosGenerale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUNAT_TributosGenerales");

                entity.Property(e => e.CodCategoriaTributo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoTributo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdentificadorTributo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MontoBaseImponible)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTributo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTributo)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SunatUnidadMedida>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("SUNAT_UnidadMedidas");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<TblPerfil>(entity =>
            {
                entity.ToTable("tblPerfil");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegla>(entity =>
            {
                entity.ToTable("tblRegla");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Regla)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsuario>(entity =>
            {
                entity.ToTable("tblUsuario");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.TblUsuarios)
                    .HasForeignKey(d => d.PerfilId);
            });

            modelBuilder.Entity<TipoAfectacionIgv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TipoAfectacionIGV");

                entity.Property(e => e.CodNubefact).HasColumnName("COD_NUBEFACT");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Idtipo).HasColumnName("IDTIPO");
            });

            modelBuilder.Entity<Tipocambio>(entity =>
            {
                entity.ToTable("TIPOCAMBIOS");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Compra).HasColumnType("money");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Venta).HasColumnType("money");
            });

            modelBuilder.Entity<Tipocomprobante>(entity =>
            {
                entity.ToTable("TIPOCOMPROBANTES");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Coddoc)
                    .HasMaxLength(25)
                    .HasColumnName("CODDOC");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Tipodoc>(entity =>
            {
                entity.ToTable("TIPODOC");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipodocParte>(entity =>
            {
                entity.ToTable("TIPODOC_PARTES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Id1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("id1");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(80)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Tipodocumento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_TIPODOCUMENTOS_1");

                entity.ToTable("TIPODOCUMENTOS");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(1)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Tipomovimiento>(entity =>
            {
                entity.HasKey(e => e.Codtip);

                entity.ToTable("TIPOMOVIMIENTO");

                entity.Property(e => e.Codtip).HasColumnName("codtip");

                entity.Property(e => e.Cod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .IsFixedLength(true);

                entity.Property(e => e.Modo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("modo")
                    .IsFixedLength(true);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Tiposnotascredito>(entity =>
            {
                entity.ToTable("TIPOSNOTASCREDITO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Tiposnotasdebito>(entity =>
            {
                entity.ToTable("TIPOSNOTASDEBITO");

                entity.Property(e => e.Activado).HasColumnName("ACTIVADO");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<TotalValorizado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Almacen)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.TotalCosto).HasColumnType("money");

                entity.Property(e => e.TotalVenta).HasColumnType("money");
            });

            modelBuilder.Entity<TransPerfilRegla>(entity =>
            {
                entity.HasKey(e => new { e.PerfilId, e.ReglaId });

                entity.ToTable("transPerfilRegla");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.TransPerfilReglas)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transPerfilRegla_tblPerfil");

                entity.HasOne(d => d.Regla)
                    .WithMany(p => p.TransPerfilReglas)
                    .HasForeignKey(d => d.ReglaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transPerfilRegla_tblRegla");
            });

            modelBuilder.Entity<Transporte>(entity =>
            {
                entity.ToTable("TRANSPORTES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(80)
                    .HasColumnName("contacto");

                entity.Property(e => e.Correo)
                    .HasMaxLength(80)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .HasColumnName("direccion");

                entity.Property(e => e.Direccion2)
                    .HasMaxLength(150)
                    .HasColumnName("direccion2");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .HasColumnName("proveedor");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ruc");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Transportista>(entity =>
            {
                entity.HasKey(e => e.IdTransportista);

                entity.Property(e => e.IdTransportista).HasColumnName("idTransportista");

                entity.Property(e => e.DesTipoDocTrans).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(35);

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RUC");

                entity.Property(e => e.TipoDocTrans)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Traslado>(entity =>
            {
                entity.ToTable("TRASLADOS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ubigeo>(entity =>
            {
                entity.ToTable("UBIGEO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Urbanizacion).HasMaxLength(50);

                entity.HasOne(d => d.IdCliNavigation)
                    .WithMany(p => p.Ubigeos)
                    .HasForeignKey(d => d.IdCli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UBIGEO_CLIENTES");
            });

            modelBuilder.Entity<Ubigeo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UBIGEOS", "Maestro");

                entity.Property(e => e.CodigoDepartamento)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodigoDistrito)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodigoProvincia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodigoUbigeo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public async Task<List<PedidosFecha>> ListaPedidosFechaAsync(DateTime fechaInicio,DateTime fechaFin, int idCliente)
        {
            List<PedidosFecha> list = new List<PedidosFecha>();
            try
            {
                SqlParameter pFechaInicio = new SqlParameter("@fechainicio", fechaInicio.ToString() ?? (object)DBNull.Value);
                SqlParameter pFechaFin = new SqlParameter("@fechafin", fechaFin.ToString() ?? (object)DBNull.Value);
                SqlParameter pCliente = new SqlParameter("@idcliente", idCliente.ToString() ?? (object)DBNull.Value);

                string sqlQuery = "EXEC [dbo].[USP_LISTARPEDIDOSPORFECHA] @fechainicio,@fechafin,@idcliente";

                list = await this.Set<PedidosFecha>().FromSqlRaw(sqlQuery, pFechaInicio, pFechaFin, pCliente).ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
