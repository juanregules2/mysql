
using UnityEngine;
using System;
using System.Data;
using MySql.Data.MySqlClient;


public class adminMySQL : MonoBehaviour {

	public string servidorBaseDatos;
	public string nombreBaseDatos;
	public string usuarioBaseDatos;
	public string contraseñaBaseDatos;

	private string datosConexion;
	private MySqlConnection conexion;
	// Use this for initialization
	void Start () {


//server=127.0.0.1;uid=root;pwd=12345;database=test"
		datosConexion= "server=127.0.0.1;uid=root;pwd=xxxxxx;database=prueba_uno"	;
		Debug.Log("datosconexion:"+datosConexion);
		
		MySqlConnection dbcon;
		
		
		dbcon=new MySqlConnection(datosConexion);
		Debug.Log("state:"+dbcon.State);
		Debug.Log(dbcon.ConnectionString);
		Debug.Log(dbcon.ConnectionTimeout);
		Debug.Log(dbcon.Database);
		Debug.Log(dbcon.DataSource);	
		bool sepudo=conectabool(dbcon);
		Debug.Log("conexion:"+sepudo);
		
		 
		
		
		
		
		//conectarConServidorBaseDatos();

		

		
		
	
		
	//	dbcon.Open();

		
		
		
			
		
		
		


		/*"Server=" +servidorBaseDatos+";"+
		 "Database=" +nombreBaseDatos+";"+
		  "User ID=" +usuarioBaseDatos+";"+
		   "Password=" +contraseñaBaseDatos+";"+ 
		"Pooling=false";*/
		
		//conectarConServidorBaseDatos();
		
	}

	public bool conectabool(MySqlConnection dbcon){
		try
		{
		dbcon.Open();
		return true;
		}
		catch (MySqlException ex)
			{
		switch (ex.Number)
			{
			case 0:
			Debug.Log("No puede conectar al server");
			break;

			case 1045:
			Debug.Log("Username/password invalido");
			break;
			}
			return false;
			}
	}


	private void conectarConServidorBaseDatos(){
		try{
			conexion = new MySqlConnection(datosConexion);

		
			conexion.Open();
			Debug.Log("Conexion con BD correcta!");
		}
		catch(MySqlException error)
		{
			Debug.Log("Imposible conectar!:"+error);

		}

	}
}
//KEYNOTFOUND EXCEPTION