namespace CollectionHierarchy.Core
{
    using System;
    using CollectionHierarchy.Models;
    using CollectionHierarchy.Contracts;
    using System.Text;
    using System.Linq;

    public class Engine
    {
        private AddCollection addCollection;
        private AddRemoveCollection addRemoveCollection;
        private MyList myList;

        public Engine()
        {
            this.addCollection = new AddCollection();
            this.addRemoveCollection = new AddRemoveCollection();
            this.myList = new MyList();
        }

        public void Run()
        {
            string[] wordsToAdd = Console.ReadLine().Split();
            int nToRemove = int.Parse(Console.ReadLine());

            AddItems(wordsToAdd);
            RemoveItems(nToRemove);
            
        }

        private void RemoveItems(int nToRemove)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    for (int j = 0; j < nToRemove; j++)
                    {
                        sb.Append(addRemoveCollection.RemoveElement()+" ");
                    }

                }

                else
                {
                    for (int j = 0; j < nToRemove; j++)
                    {
                        sb.Append(myList.RemoveElement() + " ");
                    }
                }

                Console.WriteLine(sb.ToString().TrimEnd());
                sb.Clear();
            }
            
        }

        private void AddItems(string[] wordsToAdd)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                if (i==0)
                {
                    foreach (var word in wordsToAdd)
                    {
                        sb.Append(addCollection.AddItem(word) + " ");
                    }
                }
                else if (i==1)
                {
                    foreach (var word in wordsToAdd)
                    {
                        sb.Append(addRemoveCollection.AddItem(word) + " ");
                    }
                }
                else
                {
                    foreach (var word in wordsToAdd)
                    {
                        sb.Append(myList.AddItem(word) + " ");
                    }
                    
                }

                Console.WriteLine(sb.ToString().TrimEnd());
                sb.Clear();
                
            }

            

        }
    }
}
