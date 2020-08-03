using System;

class MainClass {
  public static void Main (string[] args) {
	  
        bool state = true;
	bool login = false;
	string [] user = new String [6];
	  
		 while(state){
	    	    string[] sergio = new string [] {"Sergio Sabini","40225568598", "123", "Administrador", "30/04/2020","1"};
                    string[] pedro = new string [] {"Pedro Mota","42258517597","123", "Vendedor","14/05/2020", "0"};
                    string[] abuna = new string []  {"Lyus Abuna","40329467572","123","Supervisor","23/06/2020","1"};
            
		    if(!login){
		    Console.WriteLine("Bienvenido, por favor ingrese su usuario: "); 
                    string usr = Console.ReadLine();
                    Console.WriteLine("Contraseña: "); 
                    string pass = Console.ReadLine();
		
			 if(sergio[1] == usr && sergio[2] == pass){ user = sergio; login = true;}
			 else if(pedro[1] == usr && pedro[2] == pass){ user = pedro; login = true;}
			 else if(abuna[1] == usr && abuna[2] == pass){ user = abuna; login = true;}
			 else {user = new String [5]; login = false;}
			
			 if(user[0] != null && user[5] == "1"){
			   Console.Clear();
			   Console.WriteLine("Acabas de ingresar con el usuario: " + user[1] + " y su rol es: "+user[3]); 
				 
			 }else if(user[0] != null && user[5] == "0"){
			   Console.Clear();
		           Console.WriteLine("Este usuario esta inactivo."); 
                           login = false;
				 
			 }else{
			   Console.Clear();
			   Console.WriteLine("Datos incorrectos, intentalo de nuevo."); 
			 }
		}
	}
  }
}
