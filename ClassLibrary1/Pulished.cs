using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //delegate
    public delegate void MyDelegate(int x, int y);
    public class Pulished
    {
        /*
        private MyDelegate myDelegate;
        //create the event in published class
        public event MyDelegate myEvent
        {
            add
            {
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;
            }
        }
        */
        //auto implement events
        public event MyDelegate myEvent;
        public void RaiseEvent(int a,int b)
        {
            if(this.myEvent != null) 
            { 
                this.myEvent(a, b); 
            }
            
        }
    }
}
