using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace mentoring_system.controller
{
    public class bookingState
    {
        public enum bookState
        {
            NONE,
            READY,
            PENDING,
            CANCELLED,
            COMPLETED,
        };
        public enum bookTrigger
        {
            PAYMENT,
            REGISTER,
            CHOOSEDATE,
            CANCELDATE,
            PROCEED
        }
        bookState currentState = bookState.NONE;
        public class Transition
        {
            public bookState currentState;
            public bookState finalState;
            public bookTrigger trigger;
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
            new Transition(bookState.PENDING, bookState.CANCELLED, bookTrigger.CANCELDATE),
            new Transition(bookState.PENDING, bookState.COMPLETED, bookTrigger.PROCEED)
        };

        // Precondition: trigger harus merupakan nilai yang didefinisikan di dalam bookTrigger.
        // Postcondition: kondisi currentState akan berubah ke currentState baru sesuai dengan trigger yang diberikan.
        // Exception: akan dihasilkan Exception jika trigger yang diberikan tidak didefinisikan di dalam bookTrigger.
        public void ActivateTrigger(bookTrigger trigger)
        {
            Debug.Assert(Enum.IsDefined(typeof(bookTrigger), trigger), "not a valid value.");

            currentState = GetNextState(currentState, trigger);
            Console.WriteLine("Kondisi Booking Mentoring sekarang adalah " + currentState);
        }

        // Precondition: currentState dan trigger harus merupakan nilai yang didefinisikan di dalam bookState dan bookTrigger, 
        //                 masing-masing.
        // Postcondition: fungsi ini akan mengembalikan nilai currentState yang baru sesuai dengan trigger yang diberikan.
        // Exception: akan dihasilkan Exception jika currentState atau trigger yang diberikan tidak didefinisikan di dalam bookState atau bookTrigger, 
        //                 masing-masing.
        public bookState GetNextState(bookState currentState, bookTrigger trigger)
        {
            Debug.Assert(Enum.IsDefined(typeof(bookState), currentState), "Invalid current state.");
            Debug.Assert(Enum.IsDefined(typeof(bookTrigger), trigger), "Invalid trigger.");

            bookState finalState = currentState;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition change = transisi[i];
                if (currentState == change.currentState && trigger == change.trigger)
                {
                    finalState = change.finalState;
                }
            }
            Debug.Assert(Enum.IsDefined(typeof(bookState), finalState), "Invalid final state.");
            return finalState;
        }

    }
}
