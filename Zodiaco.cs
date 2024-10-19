using System;
class Program
{
    public const int Enero = 1, Febrero = 2, Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8, Septiembre = 9, Octubre = 10, Noviembre = 11, Diciembre = 12;
    public static void Main(string[] args)
    {
        string nombreyapelli = "", signo = "",mesnaci="";
        int año = 0, añoactual = 0, edadactual = 0, mes = 0, dia = 0, mesactual = 0, diaactual = 0;
        Console.WriteLine("Ingrese su nombre y apellido");
        nombreyapelli = Console.ReadLine();
        Console.WriteLine("ingrese el año en que nacio");
        año = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el mes en que nacio  (Ingrese el numero del mes)");
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el dia en que nacio (Ingrese el numero del dia)");
        dia = int.Parse(Console.ReadLine());
        añoactual = (short)(System.DateTime.Now.Year);
        mesactual = (short)(System.DateTime.Now.Month);
        diaactual = (short)(System.DateTime.Now.Day);
      bool sw=false;
        if (dia > 31 || dia < 1 || mes > 12 || mes < 1 || año < 0 || añoactual < 0)
        {
            Console.WriteLine("Error, La fecha no es valida");
        }
        else if (dia > diaactual && mes == mesactual && año == añoactual || mes > mesactual || año > añoactual || año == añoactual)
            Console.WriteLine("Usted viene del futuro larguese");
       switch (mes, dia)
       {
           case (Enero, int d) when mes == Enero && dia >= 1 && dia <= 19:
               signo = "Su signo es Capricornio";mesnaci="enero";
               break;
           case (Enero, int d) when mes == Enero && dia >= 20 && dia <= 31:
               signo = "Su signo es Acuario"; mesnaci="enero";
               break;
           case (Febrero, int d) when mes == Febrero && d >= 1 && d <= 18:
               signo = "Su signo es Acuario";mesnaci="febrero";
               break;
           case (Febrero, int d) when mes == Febrero && d >= 19 && d <= 29:
               signo = "Su signo es Piscis";mesnaci="febrero";
               break;
           case (Marzo, int d) when mes == Marzo && d >= 1 && d <= 20:
               signo = "Su signo es Piscis";mesnaci="marzo";
               break;
           case (Marzo, int d) when mes == Marzo && d >= 21 && d <= 30:
               signo = "Su signo es Aries";mesnaci="marzo";
               break;
           case (Abril, int d) when mes == Abril && d >= 1 && d <= 19:
               signo = "Su signo es Aries"; mesnaci="abril";
               break;
           case (Abril, int d) when mes == Abril && d >= 20 && d <= 30:
               signo = "Su signo es Tauro";mesnaci="abril";
               break;
           case (Mayo, int d) when mes == Mayo && d >= 1 && d <= 20:
               signo = "Su signo es Tauro";mesnaci="mayo";
               break;
           case (Mayo, int d) when mes == Mayo && d >= 21 && d <= 31:
               signo = "Su signo es Geminis"; mesnaci="mayo";
               break;
           case (Junio, int d) when mes == Junio && d >= 1 && d <= 20:
               signo = "Su signo es Geminis"; mesnaci="junio";
               break;
           case (Junio, int d) when mes == Junio && d >= 21 && d <= 29:
               signo = "Su signo es Cancer"; mesnaci="junio";
               break;
           case (Julio, int d) when mes == Julio && d >= 1 && d <= 22:
               signo = "Su signo es Cancer"; mesnaci="julio";
               break;
           case (Julio, int d) when mes == Julio && d >= 22 && d <= 31:
               signo = "Su signo es Leo"; mesnaci="julio";
               break;
           case (Agosto, int d) when mes == Agosto && d >= 1 && d <= 22:
               signo = "Su signo es Leo";mesnaci="agosto";
               break;
           case (Agosto, int d) when mes == Agosto && d >= 23 && d <= 31:
               signo = "Su signo es Virgo"; mesnaci="agosto";
               break;
           case (Septiembre, int d) when mes == Septiembre && d >= 1 && d <= 22:
               signo = "Su signo es Virgo"; mesnaci="septiembre";
               break;
           case (Septiembre, int d) when mes == Septiembre && d >= 23 && d <= 30:
               signo = "Su signo es Libra"; mesnaci="septiembre";
               break;
           case (Octubre, int d) when mes == Octubre && d >= 1 && d <= 22:
               signo = "Su signo es Libra"; mesnaci="octubre";
               break;
           case (Octubre, int d) when mes == Octubre && d >= 23 && d <= 31:
               signo = "Su signo es Escorpio"; mesnaci="octubre";
               break;
           case (Noviembre, int d) when mes == Noviembre && d >= 1 && d <= 21:
               signo = "Su signo es Escorpio"; mesnaci="noviembre";
               break;
           case (Noviembre, int d) when mes == Noviembre && d >= 22 && d <= 30:
               signo = "Su signo es Sagitario"; mesnaci="noviembre";
               break;
           case (Diciembre, int d) when mes == Diciembre && d >= 1 && d <= 21:
               signo = "Su signo es Sagitario"; mesnaci="diciembre";
               break;
           case (Diciembre, int d) when mes == Diciembre && d >= 22 && d <= 31:
               signo = "Su signo es Capricornio"; mesnaci="diciembre";
               break;
        }
if(sw== true){
 if(sw==false)
  if(dia <= diaactual && mes == mesactual || mes < mesactual)
edadactual=(short)(añoactual-año);
else
edadactual=(short)(añoactual-año-1);
Console.WriteLine("\t\t reporte final del Programa En C# signo y edad"+ "Señor "+nombreyapelli +" al dia de hoy "+diaactual+" de "+mesnaci+" del año "+añoactual+" con una fecha de nacimiento"+dia.ToString() +" de "+mesnaci.ToString() +" del año "+año+ "su signo es "+signo+" y su edad es "+edadactual+" años");
}
  }
       }
