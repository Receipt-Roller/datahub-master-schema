# RRDataHubMasterSchema

The `RRDataHubMasterSchema` project is a collection of class definitions that represent all types of data used within the Retail Data Hub by RECEIPTROLLER.

## Getting Started

Setting up `RRDataHubMasterSchema` is straightforward:

1. Install the library via NuGet: Install-Package RRDataHubMasterSchema -Version [LatestVersion] Replace `[LatestVersion]` with the current version number.

2. Reference the library in your project.

3. There's no need for explicit testing procedures—simply run your project!

## Contributing

We welcome contributions to `RRDataHubMasterSchema`! Here's how you can help:

1. Fork the repository from [Receipt-Roller/datahub-master-schema](https://github.com/Receipt-Roller/datahub-master-schema).
2. Create your feature branch (`git checkout -b feature/my-new-feature`).
3. Commit your changes (`git commit -am 'Add some feature'`).
4. Push the branch (`git push origin feature/my-new-feature`).
5. Submit a pull request to the main repository.

Once you've submitted a pull request, our team will review your proposed changes. Ensure that you provide a comprehensive description of the changes you're proposing to facilitate the review process.

## Links

- **GitHub Repository**: [Receipt-Roller/datahub-master-schema](https://github.com/Receipt-Roller/datahub-master-schema)

## License

This project is licensed under the MIT License. The MIT License is a short and simple permissive license that allows for reuse with few restrictions. It permits use, modification, and distribution while ensuring the original creators receive credit for their work.

## History
- 1.0.13.0 Added Inventory, InventoryTransaction.
- 1.0.12.0 Added Person.
- 1.0.11.0 Fixed error on ProductGroup HasAdultConsideration null handler.
- 1.0.10.0 Added list of ProductGroup within.
- 1.0.09.0 Updated Brand, ProductGroup classes
- 1.0.08.0 Parameterless constructor for deserialization in Place
- 1.0.07.0 Parameterless constructor for deserialization in PostalAddress
- 1.0.06.0 Add GeoCoordinate class
- 1.0.05.0 Set parameterless constructor for deserialization