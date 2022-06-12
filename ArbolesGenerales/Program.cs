using ArbolesGenerales;

ArbolGeneral arbol = new ArbolGeneral("A");

//Console.WriteLine("* * * * A R B O L * G E N E R A L * * * *");
//Console.WriteLine("Seleccionar el método que desea ejecutar");
//int seleccion = int.Parse(string Console.ReadLine());
//Console.WriteLine("1.  INSERTAR  NODO");
//Console.WriteLine("2.  RECORRER  ÁRBOL");
//Console.WriteLine("3.  OBTENER ÁRBOL");//Obteber Arbol
//Console.WriteLine("4.  BUSCAR  NODO");//Buscar NODO

//switch (seleccion)
//{
//    case 1:
//        Insertar();

//}



Nodo nodoB = arbol.Insertar(arbol.Raiz, "B");
Nodo nodoC = arbol.Insertar(arbol.Raiz, "C");
Nodo nodoD = arbol.Insertar(nodoB, "D");
Nodo nodoE = arbol.Insertar(nodoD, "E");
Nodo nodoF = arbol.Insertar(nodoD, "F");
Nodo nodoG = arbol.Insertar(nodoB, "G");
Nodo nodoH = arbol.Insertar(nodoB, "H");



string arbolCompleto = arbol.ObteberArbol();
Console.WriteLine(arbolCompleto);



