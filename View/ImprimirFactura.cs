using PCTECSANTIAGO.Model;
using PCTECSANTIAGO.Controller;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace PCTECSANTIAGO.View
{
  public   class ImprimirFactura
    {
        public static String archivo = "FacturacionPDF.pdf";
        public static void FacturaPDF(int IdFactura)
        {
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@archivo, FileMode.Create));
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("PCTEC SANTIAGO Factura No. 00"+IdFactura);
            doc.AddCreator("sjimenez@");

            // Abrimos el archivo
            // Abrimos el archivo
            doc.Open();

            //definiendo las fuentes
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font style = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font style2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
           
            
            iTextSharp.text.Font style2_WHITE = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
            iTextSharp.text.Font styleTitleCelda = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font styleContentCelda = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //fin definicion de fuentes
            // DIBUJAMO : el encabezamiento en el documento



            //--------------TABLA ENCABEZADO------------------------->
            //TABLAS EXPORTADA ----------------------------------------
            // Creamos un titulo personalizado con tamaño de fuente 18 y color Azul
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.BLACK);
            title.Add("");
            doc.Add(title);
            // Agregamos un parrafo vacio como separacion.
            doc.Add(new Paragraph(" "));

            // Empezamos a crear la tabla, definimos una tabla de 6 columnas
            PdfPTable tablePrincipal = new PdfPTable(3);
          PdfPCell cellCust = new PdfPCell(new Phrase("PCTEC SANTIAGO", style2_WHITE));
           //PdfPCell cellCust = new PdfPCell(new Phrase("                 ", style2_WHITE));

            cellCust.Colspan = 3; cellCust.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right 
         cellCust.BackgroundColor = new BaseColor(20, 62, 69);
            cellCust.BorderColor = new BaseColor(20, 62, 69);
            tablePrincipal.AddCell(cellCust);

            // ROW HEADER DE LA FILA
            //Anadiendo imagen

            String imagePath = "../../Resources/LOGO_PCTEC_SANTIAGO_FONT_GREEN.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);

            img.ScaleToFit(120.0F, 120.0F);//El tamano que deseamos para el logo
            img.SpacingBefore = 5.0F;
            img.SpacingAfter = 5.0F;
            img.SetAbsolutePosition(10, 200);

            //INSERTAMOS LA IMG DIRECTAMENTE EN LA CELDA
            PdfPCell cell = new PdfPCell(img);
            cell.Rowspan = 4;
            cell.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right
            cell.VerticalAlignment=1;
            cell.Border = 0;
            tablePrincipal.AddCell(cell);





            //Codigo Para mostrar datos de la orden

            List<Facturas> DatosFac = FacturaDB.ObtenerDatosFactura(IdFactura);

            foreach (var reg in DatosFac)
            {
                //string date = dateTimeFechaPago.Value.ToString("yyyy-MM-dd");
                string fecha = reg.Fecha;
                DateTime ValorFecha = Convert.ToDateTime(fecha);
                 string fechaMostrar = ValorFecha.ToString("yyyy-MM-dd");



                PdfPCell celda = new PdfPCell(new Phrase("                Factura No.", styleTitleCelda));
                celda.Border = 0;
                // cell.HorizontalAlignment =8 ;
                tablePrincipal.AddCell(celda);

                celda = new PdfPCell(new Phrase("                   00"+reg.Id, styleContentCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);




                celda = new PdfPCell(new Phrase("                Fecha", styleTitleCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);

                celda = new PdfPCell(new Phrase("                   "+ fechaMostrar, styleContentCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);




                celda = new PdfPCell(new Phrase("                Estado", styleTitleCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);

                celda = new PdfPCell(new Phrase("                   Realizado", styleContentCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);


                celda = new PdfPCell(new Phrase("                NIT", styleTitleCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);

                celda = new PdfPCell(new Phrase("                   73240532-1", styleContentCelda));
                celda.Border = 0;
                tablePrincipal.AddCell(celda);


            }
            //




            // Agregamos la tabla al documento
            doc.Add(tablePrincipal);
            // Ceramos el documento

            // FIN TABLAS EXPORTADA ----------------------------------------



            //--------------FIN TABLA ENCABEZADO------------------------->

            ///ESPACIOOOOOOOO///////////////////////////////
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            ///ESPACIOOOOOOOO///////////////////////////////


            //TABLA CLIENTE ----------------------------------------------------
     



            PdfPTable tablaPropietario = new PdfPTable(2);
            PdfPCell cellprop = new PdfPCell(new Phrase("Datos del Cliente", style2_WHITE));
            cellprop.Colspan = 3; cellprop.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right 
            cellprop.BackgroundColor = new BaseColor(20, 62, 69);
            cellprop.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(cellprop);




            //for each
            Clientes Cli = new Clientes();
            Cli = FacturaDB.ObtenerDatosCliente(IdFactura);
            
            PdfPCell celdaPro = new PdfPCell(new Phrase("Nombres", styleTitleCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);
            celdaPro = new PdfPCell(new Phrase(" "+Cli.Nombres+" "+Cli.Apellidos, styleContentCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);

            celdaPro = new PdfPCell(new Phrase("Contacto", styleTitleCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);
            celdaPro = new PdfPCell(new Phrase(" "+ Cli.Telefono, styleContentCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);


            celdaPro = new PdfPCell(new Phrase("Correo Electronico", styleTitleCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);
            celdaPro = new PdfPCell(new Phrase(" "+ Cli.Correo, styleContentCelda));
            celdaPro.BorderColor = new BaseColor(20, 62, 69);
            tablaPropietario.AddCell(celdaPro);


          
          

            //fin for each

            doc.Add(tablaPropietario);

            //customer tabla


            // FIN TABLA CLIENTE ----------------------------------------------------


            ///ESPACIOOOOOOOO///////////////////////////////
            doc.Add(new Paragraph(" "));

            ///ESPACIOOOOOOOO///////////////////////////////


            //TABLA DATOS DEL TECNICO ----------------------------------------------------


            PdfPTable tablaPropiedad = new PdfPTable(2);
            PdfPCell cellApto = new PdfPCell(new Phrase("Datos del Tecnico", style2_WHITE));
            cellApto.Colspan = 3; cellApto.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right 
            cellApto.BackgroundColor = new BaseColor(20, 62, 69);
            cellApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(cellApto);




            //for each
            Tecnicos tec = new Tecnicos();
            tec = FacturaDB.ObtenerDatosTecnico(IdFactura);

            PdfPCell celdaApto = new PdfPCell(new Phrase("Nombres", styleTitleCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);
            celdaApto = new PdfPCell(new Phrase(" "+tec.Nombres_tec+" "+tec.Apellidos_tec, styleContentCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);




            celdaApto = new PdfPCell(new Phrase("Contacto", styleTitleCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);
            celdaApto = new PdfPCell(new Phrase(" 3325602 - 3016121149", styleContentCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);




            celdaApto = new PdfPCell(new Phrase("Direccion", styleTitleCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);
            celdaApto = new PdfPCell(new Phrase(" Cra 46 # 65-55", styleContentCelda));
            celdaApto.BorderColor = new BaseColor(20, 62, 69);
            tablaPropiedad.AddCell(celdaApto);



            

            //fin for each

            doc.Add(tablaPropiedad);




            // FIN TABLA DATOS DE LA PROPIEDAD ----------------------------------------------------

            ///ESPACIOOOOOOOO///////////////////////////////
            doc.Add(new Paragraph(" "));

            ///ESPACIOOOOOOOO///////////////////////////////
            ///

            // TABLA ORDER DETAILS ----------------------------------------------------


            PdfPTable tableOD = new PdfPTable(7);
            PdfPCell cellOD = new PdfPCell(new Phrase("Detalle del Servicio", style2_WHITE));

            cellOD.Colspan = 7;
            cellOD.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right 
            cellOD.BackgroundColor = new BaseColor(20, 62, 69);
            cellOD.BorderColor = new BaseColor(20, 62, 69);

            tableOD.AddCell(cellOD);

            //Encabezado de tabla
            PdfPCell celdaOD = new PdfPCell(new Phrase("Codigo", styleTitleCelda));
            celdaOD.BackgroundColor = new BaseColor(98, 151, 160);
            celdaOD.BorderColor = new BaseColor(98, 151, 160);
            tableOD.AddCell(celdaOD);

            celdaOD = new PdfPCell(new Phrase("Descripcion", styleTitleCelda));
            celdaOD.Colspan = 4;
            celdaOD.BackgroundColor = new BaseColor(98, 151, 160);
            celdaOD.BorderColor = new BaseColor(98, 151, 160);
            tableOD.AddCell(celdaOD);

            ///columnas en blanco
        




            celdaOD = new PdfPCell(new Phrase("Cantidad", styleTitleCelda));
            celdaOD.BackgroundColor = new BaseColor(98, 151, 160);
            celdaOD.BorderColor = new BaseColor(98, 151, 160);
            tableOD.AddCell(celdaOD);

            celdaOD = new PdfPCell(new Phrase("Precio", styleTitleCelda));
            celdaOD.BackgroundColor = new BaseColor(98, 151, 160);
            celdaOD.BorderColor = new BaseColor(98, 151, 160);
            tableOD.AddCell(celdaOD);



            // fin Encabezado de tabla
            //customer tabla

            List<DetalleFacturas> detalle = FacturaDB.ObtenerDatosDetalleFactura(IdFactura);
            int cantidad = 0;
            double precio = 0;
            double total = 0;
            foreach (var reg in detalle)
            {



                celdaOD = new PdfPCell(new Phrase(""+reg.Id_Det_Facturas, styleContentCelda));

                celdaOD.BorderColor = new BaseColor(20, 62, 69);
                tableOD.AddCell(celdaOD);

                celdaOD = new PdfPCell(new Phrase(""+reg.Descripcion, styleContentCelda));
                celdaOD.Colspan = 4;
                celdaOD.BorderColor = new BaseColor(20, 62, 69);
                tableOD.AddCell(celdaOD);

                celdaOD = new PdfPCell(new Phrase("" + reg.Cantidad, styleContentCelda));

                celdaOD.BorderColor = new BaseColor(20, 62, 69);
                tableOD.AddCell(celdaOD);

                celdaOD = new PdfPCell(new Phrase(" $ " + reg.Precio, styleContentCelda));

                celdaOD.BorderColor = new BaseColor(20, 62, 69);
                tableOD.AddCell(celdaOD);

                cantidad = reg.Cantidad;
                precio = reg.Precio;

                total += cantidad * precio;

            }

            doc.Add(tableOD);





            // FIN TABLA DETALLE FACTURA ----------------------------------------------------
            ///ESPACIOOOOOOOO///////////////////////////////
            doc.Add(new Paragraph(" "));

            ///ESPACIOOOOOOOO///////////////////////////////


            //TABLA VALOR TOTAL ----------------------------------------------------


            PdfPTable tablaValorTotal = new PdfPTable(2);
            PdfPCell cellValorP = new PdfPCell(new Phrase("Total a Pagar", style2_WHITE));
            cellValorP.Colspan = 3; cellValorP.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right 
            cellValorP.BackgroundColor = new BaseColor(20, 62, 69);
            cellValorP.BorderColor = new BaseColor(20, 62, 69);
            tablaValorTotal.AddCell(cellValorP);




            //for each
          

            PdfPCell celdaValorP = new PdfPCell(new Phrase("Valor", styleTitleCelda));
            celdaValorP.BorderColor = new BaseColor(20, 62, 69);
            tablaValorTotal.AddCell(celdaValorP);
            celdaValorP = new PdfPCell(new Phrase(" $ "+ total, styleContentCelda));
            celdaValorP.BorderColor = new BaseColor(20, 62, 69);
            tablaValorTotal.AddCell(celdaValorP);


            //fin for each

            doc.Add(tablaValorTotal);




            // FIN TABLA VALOR TOTAL ----------------------------------------------------

            ///ESPACIOOOOOOOO///////////////////////////////
            doc.Add(new Paragraph(" "));

            ///ESPACIOOOOOOOO///////////////////////////////
            ///



            doc.Close();
            writer.Close();
            string pdfPath = Path.Combine(Application.StartupPath, archivo);
            Process.Start(pdfPath);
        }
    }
}
