#include <iostream>
using namespace std;

int main()
{
    long int corn, mult, tbox, tcorn, scorn;
    do
    {
        cin>> corn>> mult>> tbox;
        tcorn=corn;
        scorn=corn;
        if (corn!=0 && mult!=0 && tbox!=0)
        {
            for(int box=0; box<tbox-1; box++)
            {
                scorn=scorn*mult;
                tcorn=tcorn+scorn;
            }
            cout<< tcorn<<endl;
        }
    } while ( corn!=0 && mult!=0 && tbox!=0);
}
