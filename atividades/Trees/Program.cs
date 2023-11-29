using Trees;

Tree<int> tree = new Tree<int>();

//Inicializa o nó Raíz com o valor 1000
tree.Root = new TreeNode<int>() {Data = 1000};
//troca o valor de Data no nó Raíz
tree.Root.Data = 100;
//informa carga de nó filhos
tree.Root.Children = new List<TreeNode<int>> {
    new TreeNode<int>() {Data = 50, Parent = tree.Root},
    new TreeNode<int>() {Data = 5, Parent = tree.Root}
};
//adicionando nó em tempo de execução
TreeNode<int> filho3 = new TreeNode<int>();
filho3.Data = 0;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);

//adicionando netos de Root, ou seja, Filhos do primeiro nível de Hereditariedade
tree.Root.Children[0].Children = new List<TreeNode<int>> {
    new TreeNode<int>() {Data = 50, Parent = tree.Root.Children[0]}
};
//adicionando netos de root no segundo filho
TreeNode<int> neto2 = new TreeNode<int>();
neto2.Data = 200;
neto2.Parent = tree.Root.Children[1];
tree.Root.Children[1].Children = new List<TreeNode<int>>();.Add(neto2);

int level = tree.Root.GetHeight();
string message = $"Esta arvore contem {level} nivel";
Console.WriteLine(message);