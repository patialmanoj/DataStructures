using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            // call the particular DS from Here
            // Link  List ;
            SLinkList sll = new SLinkList();
            int[] arr =  { 2, 5, 4, 9, 8, 10 };

            //SingleNode head=  sll.createSingleLinkListFromArray(arr);
            //sll.displaySingleLinkList(head);
            //head = sll.reverseSingleLinkList(head);
            //sll.displaySingleLinkList(head);
            //head= sll.addNodeAfterGivenValue(head, 4, 22);
            //head= sll.addNodeAtLast(head, 25);
            //head = sll.addNodeatFirst(head, 1);

            SingleNode newHead = null ,last = null;
            //  newHead = sll.createSingleListRecursive(arr, newHead, last, 0);
            //sll.displaySingleLinkList(newHead);
            // last = newHead;
            // SingleNode prev = null;
            // newHead=  sll.ReverseSLLRecursive(newHead, last, prev);
            //sll.displaySingleLinkList(newHead);
            //newHead= sll.deleteNodeInSLL(newHead, 9);
            //newHead = sll.deleteNodeInSLL(newHead, 10);
            //newHead = sll.deleteNodeInSLL(newHead, 2);
            // SingleNode proxy = null;
            //sll.deleteNodeInSLL(proxy, 45);
            //sll.displaySingleLinkList(newHead);
            //newHead = sll.reverseEachKthPartOfSLL(newHead, 1);
            //sll.displaySingleLinkList(newHead);

            #region mindboggling
            MindBogglng objBoggle = new MindBogglng();
            objBoggle.getMaxEvenNumber("1265879");
            #endregion
        }
    }
}
