public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    private int ultimoCanal = 1; // guarda o último canal assistido

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 20; // volume inicial padrão
        Canal = CANAL_MIN; // inicia no primeiro canal
        Estado = false; // desligada por padrão
    }

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }
    public bool Mudo { get; private set; }

    // ---------------------------
    // MÉTODOS DE LIGA/DESLIGA
    // ---------------------------
    public void Ligar()
    {
        Estado = true;
        Canal = ultimoCanal; // volta para o último canal
        Console.WriteLine("TV ligada.");
    }

    public void Desligar()
    {
        Estado = false;
        ultimoCanal = Canal; // salva canal antes de desligar
        Console.WriteLine("TV desligada.");
    }

    // ---------------------------
    // MÉTODOS DE VOLUME
    // ---------------------------
    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("TV já está no volume máximo.");
    }

    public void DiminuirVolume()
    {
        if (Volume > VOL_MIN)
            Volume--;
        else
            Console.WriteLine("TV já está no volume mínimo.");
    }

    public void AtivarMudo()
    {
        Mudo = true;
        Console.WriteLine("TV no modo mudo.");
    }

    public void DesativarMudo()
    {
        Mudo = false;
        Console.WriteLine("Mudo desativado.");
    }

    // ---------------------------
    // MÉTODOS DE CANAL
    // ---------------------------
    public void ProximoCanal()
    {
        if (Canal < CANAL_MAX)
            Canal++;
        else
            Canal = CANAL_MIN; // volta para o primeiro canal
    }

    public void CanalAnterior()
    {
        if (Canal > CANAL_MIN)
            Canal--;
        else
            Canal = CANAL_MAX; // vai para o último canal
    }

    public void IrParaCanal(int numero)
    {
        if (numero >= CANAL_MIN && numero <= CANAL_MAX)
            Canal = numero;
        else
            Console.WriteLine($"Canal inválido. Informe entre {CANAL_MIN} e {CANAL_MAX}.");
    }
}
