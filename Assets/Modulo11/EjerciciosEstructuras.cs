using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> integers_list = generate_list(10, 0, 20);
        Debug.Log("*******Lista de Enteros Aleatorios*******");
        foreach (int integer in integers_list)
        {
            Debug.Log(integer);
        }

        Debug.Log("*******Ordenar Lista de Números de Manera Descendente*******");
        int[] descendent_integers_list = descendent_order(integers_list.ToArray());
        foreach (int integer in descendent_integers_list)
        {
            Debug.Log(integer);
        }

        Debug.Log("*******Eliminar Palabras Repetidas*******");
        List<string> duplicated_strings = new List<string>();
        duplicated_strings.Add("Manzana");
        duplicated_strings.Add("Manzana");
        duplicated_strings.Add("Pera");
        duplicated_strings.Add("Uva");
        duplicated_strings.Add("Fresa");
        duplicated_strings.Add("Fresa");
        Debug.Log("Lista con palabras repetidas:");
        foreach (string str in duplicated_strings)
        {
            Debug.Log(str);
        }
        HashSet<string> without_duplicated_strings = eliminate_duplicate_elements(duplicated_strings);
        Debug.Log("Hash con palabras repetidas eliminados:");
        foreach (string str in without_duplicated_strings)
        {
            Debug.Log(str);
        }

        Debug.Log("*******Queue/Stack*******");
        Stack<string> mystack = new Stack<string>();
        mystack.Push("Hola");
        mystack.Push("Mundo");
        mystack.Push("Modulo 11");
        mystack.Push("Clase EBAC");
        queue_stack(mystack);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<int> generate_list(int lenght, int floor, int ceiling)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < lenght; i++)
        {
            list.Add(Random.Range(floor, ceiling + 1));
        }
        return list;
    }

    public int[] descendent_order(int[] array)
    { 
        int[] descendent_array = array.OrderByDescending(x => x).ToArray();
        return descendent_array; 
    }

    public HashSet<string> eliminate_duplicate_elements(List<string> list)
    {
        return list.ToHashSet();
    }

    public void queue_stack(Stack<string> mystack)
    {
        Queue<string> myqueue = new Queue<string>();
        foreach (string str in mystack)
        {
            Debug.Log(str);
        }

        while (myqueue.Count > 0)
        {
            string elemento = mystack.Pop();
            myqueue.Enqueue(elemento);
        }

        foreach (string str in myqueue)
        {
            Debug.Log(str);
        }
    }
}
