using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Referensi https://github.com/Satria2133/StateBasedTableDriven_SoftwareConstruction/blob/master/Program.cs

namespace mentoring_system.controller
{
    enum bookState 
    {
        NONE,
        READY,
        PENDING,
        CANCELLED,
        COMPLETED,
    };
    enum bookTrigger
    {
        PAYMENT,
        REGISTER,
        CHOOSEDATE,
        CANCELDATE
    }
    class bookingState
    {
        bookState currentState = bookState.NONE;
        public class Transition
        {
            public bookState currentState;
            public bookState
        finalState;
            public bookTrigger
        trigger;
            public Transition(bookState currentState, bookState finalState, bookTrigger trigger)
            {
                this.currentState = currentState;
                this.finalState = finalState;
                this.trigger = trigger;
            }
        }
        Transition[] transisi ={
           new Transition(bookState.NONE,bookState.READY, bookTrigger.REGISTER),
            new Transition (bookState.READY,bookState.PENDING, bookTrigger.CHOOSEDATE),
            new Transition(bookState.PENDING,bookState.COMPLETED, bookTrigger.PAYMENT),
            new Transition(bookState.PENDING, bookState.CANCELLED, bookTrigger.CANCELDATE)

        };
        private bookState GetNextState(bookState currentState, bookTrigger trigger)
        {
            bookState finalState = currentState;
            for (int i = 0; i < transisi.Length; i++) 
            {
                Transition change = transisi[i];
                if (currentState == change.currentState && trigger == change.trigger) 
                {
                    finalState = change.finalState;
                }
            }
            return finalState;
        }
        public void ActivateTrigger(bookTrigger trigger) 
        {
            currentState = GetNextState(currentState, trigger);
            Console.WriteLine("Kondisi Booking Mentoring sekarang adalah " +  currentState);    
        }
    }

}
