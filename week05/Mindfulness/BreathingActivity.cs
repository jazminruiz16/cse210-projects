/*La actividad debe comenzar con el mensaje de inicio estándar y el aviso durante la duración que utilizan todas las actividades.
La descripción de esta actividad debería ser algo como: "Esta actividad te ayudará a relajarte caminando mientras inhalas y exhalas lentamente. Despeja tu mente y concéntrate en tu respiración".
Después del mensaje inicial, al usuario se le muestran una serie de mensajes que se alternan entre "Inhala..." y "Exhala...".
Después de cada mensaje, el programa debe hacer una pausa durante varios segundos y mostrar una cuenta regresiva.
Debe continuar hasta alcanzar la cantidad de segundos que el usuario especificó para la duración.
La actividad debe concluir con el mensaje final estándar para todas las actividades.*/
using System.Threading;
using System.Threading.Tasks;
public class BreathingActivity : Activity
{
    private int _durationTime;
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
       _durationTime = duration;

    }
    public void Run()
    {
        
        _durationTime = DisplayingStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(10);
        int lengthBreatheIn1 = 1;
        int lengthBreatheOut1 = 1;
        int length1 = _durationTime % 10;
        if (length1 != 0)
        {
            if (length1 % 2 == 0)
            {
                lengthBreatheIn1 = length1 / 2;
                lengthBreatheOut1 = lengthBreatheIn1;
            }
            else
            {
                lengthBreatheIn1 = (length1 - 1) / 2;
                lengthBreatheOut1 = lengthBreatheIn1 + 1;
            }
            Console.Write("Breathe in... ");
            for (int i = 0; i < lengthBreatheIn1; i++)
            {
                int timeBreatheIn1 = lengthBreatheIn1 - i;
                Console.Write(timeBreatheIn1);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            for (int i = 0; i < lengthBreatheOut1; i++)
            {
                int timeBreatheOut1 = lengthBreatheOut1 - i;
                Console.Write(timeBreatheOut1);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationTime- length1);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            for (int i = 0; i < 4; i++)
            {
                int timeBreatheIn1 = 4 - i;
                Console.Write(timeBreatheIn1);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            for (int i = 0; i < 6; i++)
            {
                int timeBreatheOut1 = 6 - i;
                Console.Write(timeBreatheOut1);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}