#include<bits/stdc++.h>
using namespace std;

//dinh, canh, dinh bat ky
int n, m, k;
set<int> adj[100];
ifstream ifs("input.txt");
ofstream ofs("output.txt");

void init() {
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        adj[x].insert(y);
        adj[y].insert(x);
    }
    ifs >> k;
}

void getEulerCircuit(int v) {
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

    if (EC.front() == EC.back()) {
        ofs << "Co chu trinh Euler: ";
        for (int item : EC) {
            ofs << item << " ";
        }
    } else {
        ofs << "Khong co chu trinh Euler" << endl;
    }
}

int main() {
    init();
    getEulerCircuit(k);
    cout << "Da xuat ket qua ra file output.txt" << endl;

    ifs.close();
    ofs.close();
    return 0;
}
