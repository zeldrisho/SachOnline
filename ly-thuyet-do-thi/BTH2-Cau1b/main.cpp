#include <iostream>
#include <vector>
#include <fstream>
#include <cstring>
#include <queue>
using namespace std;

int n, m;
vector<int> adj[100];
bool visited[100];

void bfs(int u) {
    queue<int> q;
    q.push(u);
    visited[u] = true;
    int v;
    while (!q.empty()) {
        v = q.front();
        q.pop();
        cout << v << " ";
        for (int x : adj[v]) {
            if (!visited[x]) {
                q.push(x);
                visited[x] = true;
            }
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
    bfs(k);
    return 0;
}
