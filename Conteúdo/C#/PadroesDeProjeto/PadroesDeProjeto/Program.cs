using PadroesDeProjeto;
using PadroesDeProjeto.Facade;
using PadroesDeProjeto.PPChainOfResponsability;
using PadroesDeProjeto.PPEstrategy;
using PadroesDeProjeto.PPMediator;
using PadroesDeProjeto.PPObserver;
using PadroesDeProjeto.PPTemplateMethod;
using PadroesDeProjeto.Proxy;
using System.Diagnostics;

internal class Program
{
    public static void Main()
    {
        List<int> lista = new List<int>();
        //aqui vamos ter todas as variações, ou seja, as estratégias do algoritmo
        IAlgoritmoOrdenacao bubble = new BubbleSort();
        IAlgoritmoOrdenacao quick = new QuickSort();
        IAlgoritmoOrdenacao insert = new InsertSort();

        //agora com o contexto, vamos abstrair tudo que foi definido nas estratégias
        ContextoOrdenacao contOrd = new ContextoOrdenacao(insert);

        //agora vamos excutar o algoritmo selecionado na lista
        contOrd.ExecutarOrdenacao(lista);

        //vamos mudar o algoritmo
        contOrd.Algoritmo = quick;
        contOrd.ExecutarOrdenacao(lista);

        //vamos mudar novamente o algoritmo
        contOrd.Algoritmo = bubble;
        contOrd.ExecutarOrdenacao(lista);



    }
}

/*
Console.WriteLine("Testando o padrão Chain of Responsability");
//instanciamos os três papeis, ou seja, a cadeia de manipuladores de responsabilidade
IHandler gerente = new Gerente();
IHandler diretor = new Diretor();
IHandler presidente = new Presidente();
IHandler proprietario = new Proprietario();

gerente.DefinirProximoHandler(diretor);
diretor.DefinirProximoHandler(presidente);
presidente.DefinirProximoHandler(proprietario);


Despesa d1 = new Despesa("Boleto da água", 450);
Despesa d2 = new Despesa("Conta do bar da esquina", 950);
Despesa d3 = new Despesa("Obra do banheiro", 4500);
Despesa d4 = new Despesa("Conta da lancheria da academia", 9500);

gerente.AprovarDespesa(d1);
Console.WriteLine();
gerente.AprovarDespesa(d2);
Console.WriteLine();
gerente.AprovarDespesa(d3);
Console.WriteLine();
gerente.AprovarDespesa(d4);
*/



/*
Console.WriteLine("Testando o padrão Observer");
Sujeito s = new Sujeito(); //seria a loja que tem o produto


//agora vamos adicionar os interessados no assunto ou produto
Observador o1 = new Observador("Ricardo");
Observador o2 = new Observador("Fabrício");
Observador o3 = new Observador("Alexandre");
Observador o4 = new Observador("Guilherme");


s.RegistrarObservador(o1);
s.RegistrarObservador(o2);
s.RegistrarObservador(o3);
s.RegistrarObservador(o4);
s.RegistrarObservador(new Observador("Ana Paula"));

s.NotificarObservadores("A aula de hoje não está legal!");

s.RemoverObservador(o4);

s.NotificarObservadores("O Guilherme foi embora pois está chato pra caramba!!");
Console.WriteLine("Final do teste do padrão Observer");
*/



/*
Console.WriteLine("Testando o padrão Template Method");
Console.WriteLine("Iniciamos usando o Processo A");
Processo processo;
processo = new ProcessoA();
processo.Executar();

Console.WriteLine();

Console.WriteLine("Vamos mudar, agora ele vai virar o Processo B");
processo = new ProcessoB();
processo.Executar();

Console.WriteLine();

Console.WriteLine("Vamos mudar, agora ele vai virar o Processo C");
processo = new ProcessoC();
processo.Executar();
*/



/*
Console.WriteLine("Testando o padrão Mediator");
MediatorConcreto mediador = new MediatorConcreto();

Colega1 c1 = new Colega1(mediador);
Colega2 c2 = new Colega2(mediador);

mediador.colega1 = c1;
mediador.colega2 = c2;

c1.Enviar("Mensagem enviada pra 1");
c2.Enviar("Mensagem enviada pra 2");
*/



/*
Console.WriteLine("Testando a classe proxy ");
IServico proxy = new Proxy();
proxy.Solicitar();
*/



/*
Console.WriteLine("Testando a classe Facade!");
Facade fachada = new Facade("root", "1234");
fachada.InicializarSistema();
*/



/*A utilização do facade evita com que seja necessário sempre alterar 
no cliente novos componentes.
tudo ficará centraliado na classe Facade
SistemaBancoDeDados sbd = new SistemaBancoDeDados();
SistemaServidorWeb ssw = new SistemaServidorWeb();
SistemaAutenticacao sa = new SistemaAutenticacao("root", "1234");
sbd.IniciarBancoDeDados();
ssw.IniciarServidor();
sa.IniciarSistema();
*/




/*
Console.WriteLine("Testando o padrão de projeto Factory Method");
//Eu quero aditar a decisão de qual classe instanciar
//Cachorro c = new Cachorro();
//c.FazerSom();
//Agora podemos adiar a decisão de qual objeto vamos instanciar uma

IAnimalFactory cFactory = new CachorroFactory();
IAnimalFactory gFactory = new GatoFactory();

Cliente cli1 = new Cliente(cFactory);
cli1.InteragirComAnimal();

Cliente cli2 = new Cliente(gFactory);
cli2.InteragirComAnimal();

List<Cliente> listaClientes = new List<Cliente>();

listaClientes.Add(cli1);
listaClientes.Add(cli2);
listaClientes.Add(new Cliente(cFactory)); // to adicionando outro cachorro
listaClientes.Add(new Cliente(gFactory));
*/




/*
Console.WriteLine("Testando a classe configuração usando o padrão singleton");

ConfiguracaoSingleton config = ConfiguracaoSingleton.getInstance();
config.ExibirDados();

ConfiguracaoSingleton config2 = ConfiguracaoSingleton.getInstance();

if (config == config2)
{
    Console.WriteLine("Mesma instância - 1 e 2");
}


//Na linha abaixo, estou chamando o construtor ao cliente
//isso não podemos, pois criamos outra instância.
//O construtor deve ser privado ou protegido!
//ConfiguracaoSingleton config3 = new ConfiguracaoSingleton();

ConfiguracaoSingleton config3 = ConfiguracaoSingleton.getInstance();

if ( config == config3 )
{
    Console.WriteLine("Mesma instância - 1 e 3");
}
else
{
    Console.WriteLine("Diferente instância - 1 e 3");
}*/