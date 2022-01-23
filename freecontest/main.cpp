#include <iostream>
#include <vector>
using namespace std;

int main() {
    int n, k, cnt = 0;
    cin >> n >> k;
    vector<int> vt;
    vector<int> vt2;
    for (int i = 0; i < n; i++) {
        int x;
        cin >> x;
        if (x > 0) {
            vt.push_back(x);
        } else {
            vt2.push_back(x);
        }
    }
    for (int i = 0; i < vt.size(); i++) {
        for (int j = 0; j < vt2.size(); j++) {
            if (vt[i] - (-vt2[j]) <= k &&vt[i] - (-vt2[j]) >= -k && vt[i] >= -vt2[j]) {
                cnt++;
            }
        }
    }
    cout << cnt;
    return 0;
}
