using System;
using System.Collections;
using x1;

namespace x2
{
    class circular_loop // ZeroBasedCircularArrayLoop
    {
        // [ 1 ] [ 2 ] [ 3 ] [ 4 ] [ 5 ]
        public bool enabled   = true;
        public int  loop_size = 0;
        public int  location  = 0;
        
        public circular_loop(int array_size){  // provide array size 'new CircularLoop(5)'
            loop_size = (array_size - 1);     // using zero instead of 1 for the start location
        }

        public int next()
        {            
            if(location == loop_size) {
                location = 0; // move location to start
            } else {
                location++;  // move to next location
            }
            return location;
        }

        public int previous()
        {
            if(location == 0){
                location = loop_size; // move location to end
            } else {
                location--;          // move to previous location
            }
            return location;
        }

    }
}
