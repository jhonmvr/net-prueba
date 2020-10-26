using gestion_pistas_core.Models.util;
using gestion_pistas_core.Models.wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace gestion_pistas_core.Util
{
    public class MfcUtil
    {

		public static DateTime formatSringToDate(String date)
		{
			try
			{
				DateTime oDate = DateTime.Parse(date);
				return oDate;
			}
			catch (RelativeException e)
			{
				throw e;
			}
			catch (Exception e)
			{
				throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "NO SE PUDO PARSEAR FECHA DE STRING A DATE");
			}
		}

		public static DateTime formatSringToDate(String dateString, String format)
		{
			try
			{
				CultureInfo provider = CultureInfo.InvariantCulture;  
				DateTime dateTime14;   
				bool isSuccess6 = DateTime.TryParseExact(dateString, new string[]{ format}, provider, DateTimeStyles.None, out dateTime14); 
				if( isSuccess6 ){
					return dateTime14;
				} else {
					throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "NO SE PUDO PARSEAR FECHA DE STRING A DATE  " + dateString + "  " + format);
				}
				
			}
			catch (RelativeException e)
			{
				throw e;
			}
			catch (Exception e)
			{
				throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "NO SE PUDO PARSEAR FECHA DE STRING A DATE");
			}
		}



		 
		public static YearMonthDay calculateEdad(DateTime dateInicio) 
		{
			try {
					YearMonthDay ymd = new YearMonthDay();
					DateTime localDate = DateTime.Now;
					int edad = DateTime.Now.AddTicks(-dateInicio.Ticks).Year - 1;
					ymd.year = edad;
					return ymd;	
			}
			catch (RelativeException e)
			{
				throw e;
			}
			catch (Exception e)
			{
				throw new RelativeException(Constantes.ERROR_CODE_CUSTOM, "NO SE PUDO CALCULAR LA EDAD");
			}
		}


	
    }
}
