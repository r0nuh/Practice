/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package binary;

import java.util.Scanner;

/**
 *
 * @author Szilard
 */
public class Binary {

    /**
     * @param args the command line arguments
     */
    static int maxNoOfConsecutiveOnes(int n){
       char[] binary = Integer.toBinaryString(n).toCharArray();
       int count = 0;
       int max = 0;
      
       for (int i = 0; i < binary.length; i++){
           if (binary[i] == '1'){
               ++count;
           }               
           else if (binary[i] == '0' && count > 0){               
               count = 0;
           }
          
           max = Math.max(max, count);
       }
       
       return max;
   }


   private static final Scanner scanner = new Scanner(System.in);

   public static void main(String[] args) {
       System.out.print("Enter a positive number: ");
       int n = scanner.nextInt();
       scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

       scanner.close();
       System.out.println("The maximum number of consecutive 1's in the binary number: " 
               + maxNoOfConsecutiveOnes(n));
   }   
}
