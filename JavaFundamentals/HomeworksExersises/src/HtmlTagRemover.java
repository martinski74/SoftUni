import java.io.*;

import java.util.*;



public class HtmlTagRemover {

    private static final String INPUT_FILE_NAME = "text.html";

    private static final String OUTPUT_FILE_NAME = "text.txt";

    private static final String CHARSET = "windows-1251";



    public static void main(String args[]) {



        Scanner scanner = null;

        PrintWriter writer = null;

        try {

            scanner = new Scanner(

                    new File(INPUT_FILE_NAME), CHARSET);

            writer = new PrintWriter(OUTPUT_FILE_NAME, CHARSET);



            while (scanner.hasNextLine()) {

                String line = scanner.nextLine();

                line = removeAllTags(line);

                line = removeDoubleNewLines(line);

                line = trimNewLines(line);

                if (! line.equals("")) {

                    writer.println(line);

                }

            }

        } catch (IOException ioex) {

            System.err.println("Can read or write file " + ioex);

        } finally {

            if (scanner != null) {

                scanner.close();

            }

            if (writer != null) {

                writer.close();

            }

        }

    }



    private static String removeAllTags(String str) {

        String strWithoutTags = str.replaceAll("<[^>]*>", "\n");

        return strWithoutTags;

    }



    private static String trimNewLines(String str) {

        int start = 0;

        while (start < str.length() && str.charAt(start)=='\n') {

            start++;

        }



        int end = str.length()-1;

        while (end >= 0 && str.charAt(end)=='\n') {

            end--;

        }



        if (start > end) {

            return "";

        }



        String trimmed = str.substring(start, end+1);

        return trimmed;

    }



    private static String removeDoubleNewLines(String str) {

        while (str.indexOf("\n\n") != -1) {

            str = str.replaceAll("\n\n", "\n");

        }

        return str;

    }

}