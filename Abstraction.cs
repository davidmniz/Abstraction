using System; 

namespace Abstraction{}

public abstract class kampus
  { 
    public abstract void namakampus(); 
    
  } 

public class kampus1 : kampus { 

    public override void namakampus() 
    { 
        Console.WriteLine("Halo selamat datang di Amikom"); 
    } 
} 

public class kampus2 : kampus { 

  public override void namakampus()
  {
    Console.WriteLine("Halo selamat datang di UGM");
  }
}
public class main_method { 
    public static void Main() 
    { 
        kampus a = new kampus1();
        a.namakampus(); 
        kampus u = new kampus2();
        u.namakampus();
    } 
}   