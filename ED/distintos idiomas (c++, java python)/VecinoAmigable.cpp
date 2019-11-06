#include <iostream> 
using namespace std;
int main()
{
    int N, S, A, B, DSB, DAB;
    cin>>N;
    for(int i=0; i<N; i++)
    {
        cin>> S>> A>> B;
        if(abs(S-A) <= abs(S-B))
            DSB=abs(S-A);
        else
            DSB=abs(S-B);
        if(A>=B)
            DAB=A-B;
        else
            DAB=B-A;
        cout<<DSB+DAB<<endl;
    }
}
