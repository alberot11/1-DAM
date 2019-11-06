#include <iostream> 
using namespace std;
int main()
{
    int N, S, A, B, DSB, DAB;
    cin>>N;
    for(int i=0; i<N; i++)
    {
        cin>> S>> A>> B;
        if(abs(S-A) <= abs(S-B) && A>=B)
        {
            DSB=abs(S-A);
            DAB=A-B;
        }
        else if(abs(S-A) <= abs(S-B) && A<=B)
        {
            DSB=abs(S-A);
            DAB=B-A;
        }
        else if (abs(S-A) >= abs(S-B) && A<=B)
        {
            DSB=abs(S-B);
            DAB=B-A;
        }
        else 
        {
            DSB=abs(S-B);
            DAB=A-B;
        } 
        cout<<DAB+DSB<<endl;
    }
}
