#include <iostream>
#include <vector>
using namespace std;

int isValid(vector<int>& vt, int k) {
    int n = vt.size();
    int median;
    if (n % 2 == 0) {
        median = vt[n/2 + 1];
    } else {
        median = vt[(n + 1)/2];
    }
    if (median >= k) {
        return 1;
    }
    return 0;
}

int main() {
    return 0;
}
