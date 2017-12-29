SimpleMovingAverages.cs and TimeSeriesData.cs tie directly to the API
SmaTrendData.cs is a view model that is put together in a service with the API models above.
We would rather have view models get returned to the view because if we return a API model to the view the view is directly tied to the API (or database)
