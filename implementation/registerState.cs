using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.Implementation
{
    public class RegisterState
    {
        public enum bookState
        {
            NONE,
            LOGIN,
            REGISTER,
            REGISTERED,
            LOGINED
        };
        public enum bookTrigger
        {
            OPEN_LOGIN_PAGE,
            OPEN_SIGNUP_PAGE,
            OPEN_DASHBOARD
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
               new Transition(bookState.NONE,bookState.LOGIN, bookTrigger.OPEN_LOGIN_PAGE),
               new Transition(bookState.NONE,bookState.REGISTER, bookTrigger.OPEN_SIGNUP_PAGE),
               new Transition(bookState.REGISTER,bookState.REGISTERED, bookTrigger.OPEN_DASHBOARD),
               new Transition(bookState.LOGIN,bookState.LOGINED, bookTrigger.OPEN_DASHBOARD)
            };
        public bookState GetNextState(bookState currentState, bookTrigger trigger)
        {
            // Prekondisi
            Debug.Assert(Enum.IsDefined(typeof(bookState), currentState), "Invalid current state.");
            Debug.Assert(Enum.IsDefined(typeof(bookTrigger), trigger), "Invalid trigger.");

            bookState finalState = currentState;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition change = transisi[i];
                if (currentState == change.currentState && trigger == change.trigger)
                {
                    finalState = change.finalState;
                    break;
                }
            }

            // Postkondisi
            Debug.Assert(Enum.IsDefined(typeof(bookState), finalState), "Invalid final state.");

            return finalState;
        }

        public void ActivateTrigger(bookTrigger trigger)
        {
            // Prekondisi
            Debug.Assert(Enum.IsDefined(typeof(bookTrigger), trigger), "Invalid trigger.");

            try
            {
                bookState newState = GetNextState(currentState, trigger);
                Console.WriteLine("Kondisi akun sekarang adalah " + newState);
                currentState = newState;
            }
            catch (Exception e)
            {
                // Exception
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
