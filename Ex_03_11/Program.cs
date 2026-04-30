using System.ComponentModel.DataAnnotations;
using Ex_03_11.Modules;
namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        Mouse mouse = new();
        FlashMemory flash = new();
        Display display = new();

        flash.SendData();
        flash.ReciveData();
        mouse.SendData();
        //mouse.ReciveData();
        //display.SendData();
        display.ReciveData();
    }
}
