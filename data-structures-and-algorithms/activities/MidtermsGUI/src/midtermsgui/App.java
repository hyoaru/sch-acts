package midtermsgui;

import com.formdev.flatlaf.FlatIntelliJLaf;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

public class App {
    public static void main(String[] args) {
        try {
            UIManager.setLookAndFeel(new FlatIntelliJLaf());
        } catch (UnsupportedLookAndFeelException e) {
            System.out.println(e.getMessage());
        }
        java.awt.EventQueue.invokeLater(
            new Runnable() {
                @Override
                public void run() {
                    new MainForm().setVisible(true);
                }
            }
        );
    }
}
