using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sem3HW
{
    public class LinkedList
    {
        public int size;
        public Node head;

        public Node tail;

        public void Add(int _value)
        {
            Node newNode = new Node();
            newNode.value = _value;
            newNode.next = null!;
            newNode.prev = null!;
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            size++;
        }

        public void Print()
        {
            Node currentNode = new Node();
            currentNode = head;
            while (currentNode != null)
            {
                System.Console.Write(currentNode.value + "  ");
                currentNode = currentNode.next;
            }

        }

        public void Remove(int _value)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.value == _value)
                {
                    if (currentNode == head)
                    {
                        head = currentNode.next;
                        if (head != null)
                        {
                            head.prev = null;
                        }
                    }
                    else if (currentNode == tail)
                    {
                        tail = currentNode.prev;
                        if (tail != null)
                        {
                            tail.next = null;
                        }
                    }
                    else
                    {
                        if (currentNode.prev != null)
                        {
                            currentNode.prev.next = currentNode.next;
                        }
                        if (currentNode.next != null)
                        {
                            currentNode.next.prev = currentNode.prev;
                        }
                    }

                }
                currentNode = currentNode.next;
            }

        }



        public void Reverse()
        {
            Node temp = null;
            Node currentNode = head;

            while (currentNode != null)
            {
                temp = currentNode.prev;
                currentNode.prev = currentNode.next;
                currentNode.next = temp;
                currentNode = currentNode.prev;
            }

            if (temp != null)
            {
                head = temp.prev;
            }
        }

    }
}
