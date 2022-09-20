#include <iostream>
#include <fstream>
#include <vector>
using namespace std;

int main() {
    ifstream ifs("ds-canh.txt");
//    n dinh, m canh
    int n, m;
    vector<int> adj[100];
//    adj[i]: Luu ds ke cua dinh i
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    for (int i = 1; i <= n; i++) {
        cout << i << ": ";
        for (int k : adj[i]) {
            cout << k << " ";
        }
        cout << endl;
    }
    ifs.close();
    return 0;
}
