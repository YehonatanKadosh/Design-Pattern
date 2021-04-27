using System.Collections.Generic;
using System.Text;

namespace Composite
{
    partial class Program
    {
        class Human
        {
            public Human(string name, Human father, Human mother)
            {
                Father = father;
                if (Father != null)
                    Father.Children.Add(this);
                Mother = mother;
                if (Mother != null)
                    Mother.Children.Add(this);
                Name = name;
            }
            public string Name { get; set; }//                                   (Father)   (Mother)
            public Human Father { get; }//                                           0         0
            public Human Mother { get; }//                                             \     /
            public List<Human> Children { get; set; } = new List<Human>();//          (Me)0
            public override string ToString()//                                       //// \\\(Children)       
            {
                StringBuilder FamilyTree = new StringBuilder();//                    0000   000
                if (Mother == null)
                    if (Father == null)
                        FamilyTree.Append("Parents is God");
                    else
                        FamilyTree.Append($"Father is {Father.Name} and mother's name unknown");
                else if (Father == null)
                    FamilyTree.Append($"Mother is {Mother.Name} and father's name is unknown");
                else
                    FamilyTree.Append($"Father is {Father.Name} and Mother is {Mother.Name}");
                if (Children.Count > 0)
                {
                    FamilyTree.Append($"\n{Name}'s Childrens ");
                    foreach (Human child in Children)
                    {
                        FamilyTree.Append($"{child.Name} ");
                    }
                }
                return FamilyTree.ToString();
            }

        }
    }
}
