using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleNode {
        public int val = -1;
        public SingleNode next ;
        public SingleNode(int val) {
            this.val = val;
            next = null;
        }
    }

    public class SLinkList
    {

        #region Iteraive 

        public SingleNode createSingleLinkListFromArray(int []arr ) {
            SingleNode head = null , last = null;
            SingleNode newNode = null;
            if (arr != null)
            {
                int length = arr.Length;
                if (length > 0)
                {
                    newNode = new SingleNode(arr[0]);
                    head = newNode;
                    last = newNode;

                    for (int i = 1; i < length; i++) {
                        newNode = new SingleNode(arr[i]);
                        last.next = newNode;
                        last = last.next;
                    }
                }
            }
            return head;
        }
        // will reverse the single link List
        public SingleNode reverseSingleLinkList(SingleNode head) {
            if (head != null)
            {
                SingleNode prev = null ,  last= null;
                //current = head;
                last = head;
                while(last != null){
                    last = head.next;
                    head.next = prev;
                    prev = head;
                    head = last;
                }
                head = prev;

            }
            else {
                Console.WriteLine("Sigle Link List is null");
            }
            return head; 
        }
        // Wil display the link list
        public void displaySingleLinkList(SingleNode head) {
            if (head != null)
            {
                SingleNode last = head;
                while (last != null)
                {
                    Console.Write(last.val + "==>");
                    last = last.next;
                }
               
            }
            else {
                Console.WriteLine("Link List is null");
            }
            Console.ReadKey();
        }
        // addd node at last 
        public SingleNode addNodeAtLast(SingleNode head, int val)
        {
            SingleNode crawler = head;
            SingleNode newNode =  new SingleNode(val);
            if (crawler != null)
            {
                while (crawler.next != null)
                {
                    crawler = crawler.next;
                }
                crawler.next = newNode;

            }
            else {
                head = newNode; // if head is null it will add here
            }
            Console.WriteLine("new Node with value " + val + "is added at last ");
            displaySingleLinkList(head);

            return head; 
        }
        // adding a node after val
        public SingleNode addNodeAfterGivenValue(SingleNode head, int a, int val) {
            SingleNode newNode = new SingleNode(val);
            SingleNode last = null, crawler = head;
            Boolean isNodePresent = false;
            if (head != null)
            {
                while (head.next != null)
                {
                    if (head.val == a)
                    {
                        last = head.next;
                        head.next = newNode;
                        newNode.next = last;
                        isNodePresent = true;
                        break;
                    }
                    head = head.next;

                }
                if (!isNodePresent)
                {
                    Console.WriteLine("nO NODE present with value " + a);
                }
                else
                {
                    Console.WriteLine("new Node with value " + val + "is added after "+a);
                    displaySingleLinkList(crawler);

                }
            }
            else
            {
                 Console.WriteLine(" Its Null Bithces SLL " );
            }
            return crawler;

        }
        // adding node at start
        public SingleNode addNodeatFirst(SingleNode head,int val) {
            SingleNode newNode = new SingleNode(val);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("new Node with value " + val + "is added at first ");
            displaySingleLinkList(head);
            return head;
        }

        public SingleNode deleteNodeInSLL(SingleNode head, int val)
        {
            bool isPresent = false;
            if (head != null)
            {
                SingleNode crawler = head;
                SingleNode prev = null;
                while (crawler != null)
                {

                    if (crawler.val == val)
                    {
                        if (prev == null)
                        {
                            prev = crawler.next;
                            head = prev;
                        }
                        else
                            prev.next = crawler.next;
                        isPresent = true;
                        crawler.next = null;
                        Console.WriteLine("Node with value " + val + " is removed from list");
                        break;

                    }
                    prev = crawler;
                    crawler = crawler.next;
                }

            }
            else
            {
                Console.WriteLine("Link List is empty bitch, what to delete");

            }
            if (!isPresent)
            {
                Console.WriteLine("come on u bitch the number " + val + ", is not present in list ");
            }

            return head;
        }

        #endregion

        #region Recursive

        public SingleNode createSingleListRecursive(int[] arr, SingleNode head, SingleNode last, int start) {

            if (arr.Length == start)
                return head;
           
            SingleNode newNode = new SingleNode(arr[start]);
            if (last != null)
                last.next = newNode;
            last = newNode;
            if (start == 0)
                head = last;
            start++;
            return createSingleListRecursive(arr, head,last, start);
            

        }

        public SingleNode ReverseSLLRecursive(SingleNode head , SingleNode last, SingleNode prev) {
            if (last == null) return prev;
            head = last.next;
            last.next = prev;
            prev = last;
            last = head;
            return ReverseSLLRecursive(head, last, prev);

        }

        #endregion

        #region logical questions
        // reverse each kth part of single link list

                
    
        public SingleNode reverseEachKthPartOfSLL(SingleNode head, int k) {
            int len = 0;
            SingleNode  prev = null, crawler = null, current = null,start= null;
            crawler = head;
          //  newhead = head;
            while (crawler != null) {
                // will move to crawler at kth index everytime
                start = crawler;
                while (len < k-1 && crawler.next !=null)
                {
                    len++;
                    crawler = crawler.next;
                }
                len = 0;
                current = crawler;
                crawler = crawler.next; // cralwer moves to start of next kth chunk of node
                current.next = null;// breaking the list
                // reverse the list 
                if (prev == null) // this would be first chunk 
                {
                    prev = ReverseSLLRecursive(start, start, null);
                    head = prev;
                }
                else
                    prev.next = ReverseSLLRecursive(start, start, null);

                while (prev != null && prev.next != null) { // to move to last of the reversed list
                    prev = prev.next;
                }
            }

            return head;
        }

        //public SingleNode sortSingleLinkList(SingleNode head) {
        //    SingleNode crawler = head , prev = null;

        //    while (crawler != null && crawler.next != null) {
        //        if (crawler.val > crawler.next.val) {
                     
        //        }

        //    }
        //}

        public void mergeandSortTwoSingleLinkList(SingleNode head1, SingleNode head2) {



        }

        #endregion


    }
}
