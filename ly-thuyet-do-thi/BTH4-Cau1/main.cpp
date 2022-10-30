#include<bits/stdc++.h>
using namespace std;

//dinh, canh
int n, m;
vector<vector<int>> g;
vector<int> col;
ifstream ifs("input.txt");
ofstream ofs("output.txt");

void init() {
    ifs >> n >> m;
    g.resize(n);
    col.resize(n);

    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        x--;
        y--;
        g[x].push_back(y);
        g[y].push_back(x);
   }
}

void greedyColoring() {
    col[0] = 0;
    for ( int i = 1; i < n; i++) {
        col[i] = -1;
    }

    bool unuse[n];
    for (int i = 0; i < n; i++) {
        unuse[i] = false;
    }

    for (int i = 1; i < n; i++) {
        for (int j = 0; j < g[i].size(); j++) {
            if (col[g[i][j]] != -1) {
                unuse[col[g[i][j]]] = true;
            }
        }

        int cr;
        for (cr = 0; cr < n; cr++) {
            if (unuse[cr] == false) {
                 break;
            }
        }
        col[i] = cr;

        for (int j = 0; j < g[i].size(); j++) {
            if (col[g[i][j]] != -1) {
                unuse[col[g[i][j]]] = false;
            }
        }
   }
}

void print() {
    for (int i = 0; i < n; i++) {
        ofs << "Dinh " << i + 1 << " --> Mau " << col[i] + 1 << endl;
    }
    cout << "Da xuat ket qua ra file output.txt" << endl;
}

int main() {
    init();
    greedyColoring();
    print();

    ifs.close();
    ofs.close();
    return 0;
}
