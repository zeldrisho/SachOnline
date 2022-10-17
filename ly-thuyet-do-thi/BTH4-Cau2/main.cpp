#include <iostream>
#include <fstream>
#include <set>
#include <stack>
#include <vector>
#include <algorithm>
using namespace std;

int n, m;
set<int> adj[100];
int deg[100];
ifstream ifs("input.txt");
ofstream ofs("output.txt");

void nhap() {
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        adj[x].insert(y);
        adj[y].insert(x);
        deg[x]++;
        deg[y]++;
    }
}

void euler(int v) {
    stack<int> st;
    vector<int> EC;
    st.push(v);
    int x, y;
    while (!st.empty()) {
        x = st.top();
        if (!adj[x].empty()) {
            y = *adj[x].begin();
            st.push(y);
//            xoa (x, y)
            adj[x].erase(y);
            adj[y].erase(x);
        } else {
            st.pop();
            EC.push_back(x);
        }
    }
    reverse(begin(EC), end(EC));
    for (int item : EC) {
        ofs << item << " ";
    }
    ofs << endl;
}

int main() {
    nhap();
//    for (int i = 1; i < n; i++) {
//        euler(i);
//    }
    euler(3);
    cout << "Da xuat ket qua ra file output.txt";
    ifs.close();
    ofs.close();
    return 0;
}
