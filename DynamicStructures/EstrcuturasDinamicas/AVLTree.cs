using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class AVLTree<T, K>
    {
        public delegate int compare<k>(T aux, T aux2);
        compare<K> compareElements;
        private int numberOfTreeNodes = 0;
        public AVLNode<T> root;

        public AVLTree(compare<K> cmp) {
            root = null;
            compareElements = cmp;
        }

        public int weight()
        {
            return numberOfTreeNodes;
        }

        public bool isEmpty() {
            return this.root == null;
        }

        private int height(AVLNode<T> root)
        {
            if (root == null) {
                return 0;
            }
            else {
                return root.getHeight();
            }
        }

        private void updateHeight (AVLNode<T> root) {
            if (root != null)
            {
                root.setHeight(Math.Max(height(root.getLeft()), height(root.getRight())) + 1);
            }
        }

        public void add(T element)
        {
            if (this.root == null)
            {
                root = new AVLNode<T>(element, null, null, null);
                numberOfTreeNodes++;
            }
            else
            {
                addElement(this.root, element);              
            }
        }

        private void addElement(AVLNode<T> root, T element)
        {
            if (compareElements(element, root.getElement()) < 0)//x es menor que y
            {
                if (root.getLeft() == null){
                    root.setLeft(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else{
                    addElement(root.getLeft(), element);
                }
            }
            else if (compareElements(element, root.getElement()) > 0)//x es mayor que y 
            {
                if (root.getRight() == null){
                    root.setRight(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else{
                    addElement(root.getRight(), element);
                }
            }

            balance(root);
            updateHeight(root);
        }

        private int numberOfChildren(AVLNode<T> root)
        {
            int count = 0;
            if (root.getLeft() != null)
                count++;
            if (root.getRight() != null)
                count++;
            return count;
        }

        private void rotation(AVLNode<T> root, bool direction)
        {
            bool son = false; //al ser falso es porque es hijo derecho
            AVLNode<T> aux;
            AVLNode<T> parent = root.getParent();

            if (root != this.root) {
                if (parent.getLeft() == root) { son = true; }
            }            

            if (direction) //si es verdadero será rotación izquierda
            {                
                aux = root.getLeft();//
                AVLNode<T> rightAux = aux.getRight();                                          
                root.setParent(aux);
                aux.setRight(root);//                

                if (rightAux != null) { rightAux.setParent(root); }

                root.setLeft(rightAux);//   
                aux.setParent(parent);

                if (root == this.root) {
                    this.root = root.getParent();
                    this.root.setParent(null);
                }
            }
            else //rotación derecha
            {
                aux = root.getRight();//
                AVLNode<T> leftAux = aux.getLeft();
                root.setParent(aux);
                aux.setLeft(root);//     

                if (leftAux != null) { leftAux.setParent(root); }

                root.setRight(leftAux);//                                                             
                aux.setParent(parent);
                

                if (root == this.root) {
                    this.root = root.getParent();
                    this.root.setParent(null);
                }
            }

            if (son) {
                parent.setLeft(aux);
            } 
            else {
                parent.setRight(aux);
            }                
            
            updateHeight(root);
            updateHeight(aux);            
        }

        private void doubleRotation(AVLNode<T> root, bool direction)
        {
            if (direction) //doble rotación izquierda
            {
                rotation(root.getLeft(), false);
                rotation(root, true);
            }
            else //doble rotación derecha
            {
                rotation(root.getRight(), true);
                rotation(root, false);
            }
        }

        void balance(AVLNode<T> root)
        {
            if (this.root != null)
            {
                if (height(root.getLeft()) - height(root.getRight()) == 2) //hay un desequilibrio a la izquierda
                {
                    if (height(root.getLeft().getLeft()) >= height(root.getLeft().getRight())) //desequilibrio simple hacia la izquierda
                    {
                        rotation(root, true);
                    }
                    else //desequilibrio doble hacia la izquierda
                    {
                        doubleRotation(root, true);
                    }
                }

                else if (height(root.getRight()) - height(root.getLeft()) == 2) //desequilibrio a la derecha
                {
                    if (height(root.getRight().getRight()) >= height(root.getRight().getLeft())) //desequiibrio simple hacia la derecha
                    {
                        rotation(root, false);
                    }
                    else //desequilibri doble hacia la derecha
                    {
                        doubleRotation(root, false);
                    }
                }
            }
        }

        public T remove(AVLNode<T> root, T element)
        {
            if (root == null)
            {
                return default(T);
            }
            else if (compareElements(element, root.getElement()) == 0)
            {
                if (numberOfChildren(root) == 0)//borrar nodo sin hijos
                {
                    T aux = root.getElement();
                    AVLNode<T> parent = root.getParent();
                    if (root == this.root){
                        this.root = null;
                    }
                    else
                    {
                        if (parent.getLeft() == root){
                            parent.setLeft(null);                            
                        }
                        else{
                            parent.setRight(null);                            
                        }
                        root = null;

                        //equilibrar el árbol
                        updateHeight(parent);
                        balance(parent);
                    }
                    numberOfTreeNodes--;
                    return aux;
                }//borrar nodo sin hijos
                else if (numberOfChildren(root) == 1)//borrar nodo con 1 hijo
                {
                    T aux = root.getElement();
                    if (root == this.root) //si es la raiz
                    {
                        if (root.getLeft() != null){
                            this.root = root.getLeft();
                        }
                        else{
                            this.root = root.getRight();
                        }
                        this.root.setParent(null);
                    }
                    else
                    {
                        AVLNode<T> parent = root.getParent();
                        AVLNode<T> son;
                        if (parent.getLeft() == root)
                        {
                            if (root.getLeft() != null){
                                son = root.getLeft();
                                son.setParent(parent);
                                parent.setLeft(son);
                            }
                            else{
                                son = root.getRight();
                                son.setParent(parent);
                                parent.setLeft(son);
                            }
                        }
                        else
                        {
                            if (root.getLeft() != null){
                                son = root.getLeft();
                                son.setParent(parent);
                                parent.setRight(son);
                            }
                            else{
                                son = root.getRight();
                                son.setParent(parent);
                                parent.setRight(son);
                            }
                        }
                        
                        updateHeight(parent);
                        balance(parent);    
                    }
                    numberOfTreeNodes--;
                    return aux;
                }//borrar nodo con 1 hijo
                else
                {//El que sustituirá será el más derecho de los izquierdos
                    AVLNode<T> next = root.getLeft();
                    T aux = root.getElement();

                    while (next.getRight() != null)
                    {
                        next = next.getRight();
                    }
                    root.setElement(next.getElement());

                    if (next != root.getLeft()) {
                        AVLNode<T> father = next.getParent();
                        father.setRight(null);
                        updateHeight(father);
                        balance(father);
                    }
                    else {
                        if (next.getLeft() != null) {
                            root.setLeft(next.getLeft());
                            next.getLeft().setParent(root);
                        }
                        else {
                            root.setLeft(null);
                        }

                        updateHeight(root);
                        balance(root);
                    }

                    numberOfTreeNodes--;
                    return aux;
                }
            }
            else
            {
                if (compareElements(element, root.getElement()) < 0)
                {
                    return remove(root.getLeft(), element);
                }
                else
                {
                    return remove(root.getRight(), element);
                }
            }
        }

        public void preOrder(AVLNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.getElement());                
                preOrder(root.getLeft());
                preOrder(root.getRight());
            }
        }

    }
}

