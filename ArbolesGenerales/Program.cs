using ArbolesGenerales;

ArbolGeneral arbol = new ArbolGeneral("A");

Nodo nodoB = arbol.Insertar(arbol.Raiz, "B");
Nodo nodoC = arbol.Insertar(arbol.Raiz, "C");
Nodo nodoD = arbol.Insertar(nodoB, "D");
Nodo nodoE = arbol.Insertar(nodoD, "E");
Nodo nodoF = arbol.Insertar(nodoD, "F");
Nodo nodoG = arbol.Insertar(nodoB, "G");


string arbolCompleto = arbol.ObteberArbol();
Console.WriteLine(arbolCompleto);

