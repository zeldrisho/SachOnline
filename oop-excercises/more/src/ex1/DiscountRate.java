package ex1;

public class DiscountRate {
    private static double serviceDiscountPremium = 0.2;
    private static double serviceDiscountGold = 0.15;
    private static double serviceDiscountSilver = 0.1;
    private static double productDiscountPremium = 0.1;
    private static double productDiscountGold = 0.1;
    private static double productDiscountSilver = 0.1;

    public static double getServiceDiscountRate(String type) {
        if (type.equals("Premium")) {
            return serviceDiscountPremium;
        }
        if (type.equals("Gold")) {
            return serviceDiscountGold;
        }
        return serviceDiscountSilver;
    }

    public static double getProductDiscountRate(String type) {
        if (type.equals("Premium")) {
            return productDiscountPremium;
        }
        if (type.equals("Gold")) {
            return productDiscountGold;
        }
        return productDiscountSilver;
    }
}
