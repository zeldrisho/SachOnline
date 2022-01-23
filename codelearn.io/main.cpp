#include <iostream>
using namespace std;

int main() {
    string s;
    getline(cin, s);
    char c = s[s.length()];
    if (c == '\n') {
        cout << "YES" << endl;
    } else {
        cout << "NO" << endl;
    }
    return 0;
}
