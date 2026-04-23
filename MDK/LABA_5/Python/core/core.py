from __future__ import annotations
from typing import Final, final, ClassVar
from requests import get
from ui.design import *
from PyQt6 import QtWidgets


@final
class Core:

    URL_CITY_COORD: Final[str] = "https://geocoding-api.open-meteo.com/v1/search"
    URL_WEATHER: Final[str] = "https://api.open-meteo.com/v1/forecast"

    latitude: ClassVar[float]
    longitude: ClassVar[float]

    @classmethod
    def init(cls):
        cls.MainWindow = QtWidgets.QMainWindow()
        cls.ui = Ui_MainWindow()

        cls.ui.setupUi(cls.MainWindow)

        cls.ui.ExecuteButton.clicked.connect(cls.execute)

    @classmethod
    def execute(cls):
        cls.get_city_coords()
        cls.get_weather()

    @classmethod
    def get_city_coords(cls) -> None:
        params = {
            "name": cls.ui.InputLine.text(),
            "format": "json",
            "language": "en"
                  }

        response = get(url=cls.URL_CITY_COORD, params=params)

        if response.status_code == 200:
            data = response.json()

            latitude = data["results"][0]["latitude"]
            longitude = data["results"][0]["longitude"]

            cls.latitude = latitude
            cls.longitude = longitude
        else:
            cls.ui.OutPutLabel.setText("Координаты не найдены!")

    @classmethod
    def get_weather(cls) -> None:
        params = {
            "latitude": cls.latitude,
            "longitude": cls.longitude,
            "current_weather": True
        }

        response = get(url=cls.URL_WEATHER, params=params)
        data = response.json()

        if response.status_code == 200:
            cls.ui.OutPutLabel.setText(f"Температура: {data.get('current_weather').get('temperature')}°C")
        else:
            cls.ui.OutPutLabel.setText("Ошибка запроса погоды")
