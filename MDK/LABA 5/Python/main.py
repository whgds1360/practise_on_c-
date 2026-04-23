from core.core import Core
from PyQt6 import QtWidgets
import sys
from ui.resources import *


if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    Core.init()
    Core.MainWindow.show()
    sys.exit(app.exec())
