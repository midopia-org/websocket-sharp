
using System;
using WebSocketSharp;

namespace Example
{
  public class Program
  {
    public static void Main (string[] args)
    {
      var token =  "70e12cdb-1b63-4277-b007-2ac9e72bb77b-d99a5156-0d1c-41ba-b9e1-17dfcb965e9d";
      using (var ws = new WebSocket("wss://midopia.liara.run/ws")) {
        ws.OnMessage += (sender, e) =>
                          Console.WriteLine ("Laputa says: " + e.Data);
        ws.OnOpen += (sender, e) => {
            Console.WriteLine("Connection opened.");
        };
        ws.Connect();
        ws.Send ($"authenticate {token} EMPTY");
        Console.ReadKey (true);
      }
    }
  }
}
