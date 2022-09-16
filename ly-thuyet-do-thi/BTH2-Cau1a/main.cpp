#include <iostream>
#include <vector>
#include <fstream>
#include <cstring>
using namespace std;

int n, m;
vector<int> adj[100];
bool visited[100];

void dfs(int u) {
    cout << u << " ";
    visited[u] = true;
    for (int v: adj[u]) {
        if (!visited[v]) {
            dfs(v);
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
    memset(visited, false, sizeof(visited));
    int k;
    ifs >> k;
    dfs(k);
    return 0;
}
