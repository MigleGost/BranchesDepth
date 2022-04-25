namespace Branches
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(TreeDepth(MakeTree()));

            //Method to calculate tree depth
            int TreeDepth(Branch root)
            {
                int maxDepth = 0;
                foreach (Branch br in root.branches)

                    maxDepth = Math.Max(maxDepth, TreeDepth(br));

                return maxDepth + 1;
            }

            //method to build a tree using Branches object
            Branch MakeTree(){

                /* Tree will look like this
                 *                  root
                 *                  /  \
                 *                 A    B
                 *               /    / | \
                 *             AA   BA  BB BC
                 *                     /  \
                 *                   BBA  BBB
                 *                        / \
                 *                     BBBA BBBB  
                 *                      |
                 *                    BBBBA
                 */ 

                Branch root = new Branch();
                Branch branchA = new Branch();
                Branch branchB = new Branch();
                Branch branchAA = new Branch();
                Branch branchBA = new Branch();
                Branch branchBB = new Branch();
                Branch branchBC = new Branch();
                Branch branchBBA = new Branch();
                Branch branchBBB = new Branch();
                Branch branchBBBA = new Branch();
                Branch branchBBBB = new Branch();
                Branch branchBBBBA = new Branch();

                root.branches.Add(branchA);
                root.branches.Add(branchB);
                branchA.branches.Add(branchAA);
                branchB.branches.Add(branchBA);
                branchB.branches.Add(branchBB);
                branchB.branches.Add(branchBC);
                branchBB.branches.Add(branchBBA);
                branchBB.branches.Add(branchBBB);
                branchBBB.branches.Add(branchBBBA);
                branchBBB.branches.Add(branchBBBB);
                branchBBBA.branches.Add(branchBBBBA);

                return root;

            }
        }
    }

    public class Branch
    {
        public List<Branch> branches = new List<Branch>(); 
    }
}

