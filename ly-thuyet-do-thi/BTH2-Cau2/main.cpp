#include <iostream>
#include <fstream>
#include <vector>
#include <cstring>
#include <algorithm>
using namespace std;

//n dinh, m canh
int n, m;
vector<int> adj[100];
bool visited[100];
int parent[100];

void dfs(int u) {
    visited[u] = true;
    for (int v : adj[u]) {
        if (!visited[v]) {
            parent[v] = u;
            dfs(v);
        }
    }
}

void Path(int s, int t) {
    memset(visited, false, sizeof(visited));
    memset(parent, 0, sizeof(parent));
    dfs(s);
    if (!visited[t]) {
        cout << "Khong co duong di" << endl;
    } else {
        vector<int> path;
        while (t != s) {
            path.push_back(t);
            t = parent[t];
        }
        path.push_back(s);
        reverse(path.begin(), path.end());
        cout << "Duong di: ";
        for (int x : path) {
            cout << x << " ";
        }
    }
}

int main() {
    ifstream ifs("do-thi-ko-lien-thong.txt");
//    ifstream ifs("do-thi-lien-thong.txt");
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
//    2 dinh bat ky
    int s, t;
    ifs >> s >> t;
    Path(s, t);
    ifs.close();
    return 0;
}
