class Account {
    private int id, balance = 0;
    private String name;
    
    public Account(int id, String name) {
        this.id = id;
        this.name = name;
    }
    
    public Account(int id, String name, int balance) {
        this.id = id;
        this.name = name;
        this.balance = balance;
    }
    
    public int getId() {
        return id;
    }
    
    public String getName() {
        return name;
    }
    
    public int getBalance() {
        return balance;
    }
}
