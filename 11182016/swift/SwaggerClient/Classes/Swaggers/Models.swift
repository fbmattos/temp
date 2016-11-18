// Models.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation

protocol JSONEncodable {
    func encodeToJSON() -> AnyObject
}

public class Response<T> {
    public let statusCode: Int
    public let header: [String: String]
    public let body: T

    public init(statusCode: Int, header: [String: String], body: T) {
        self.statusCode = statusCode
        self.header = header
        self.body = body
    }

    public convenience init(response: NSHTTPURLResponse, body: T) {
        let rawHeader = response.allHeaderFields
        var header = [String:String]()
        for (key, value) in rawHeader {
            header[key as! String] = value as? String
        }
        self.init(statusCode: response.statusCode, header: header, body: body)
    }
}

private var once = dispatch_once_t()
class Decoders {
    static private var decoders = Dictionary<String, ((AnyObject) -> AnyObject)>()

    static func addDecoder<T>(clazz clazz: T.Type, decoder: ((AnyObject) -> T)) {
        let key = "\(T.self)"
        decoders[key] = { decoder($0) as! AnyObject }
    }

    static func decode<T>(clazz clazz: [T].Type, source: AnyObject) -> [T] {
        let array = source as! [AnyObject]
        return array.map { Decoders.decode(clazz: T.self, source: $0) }
    }

    static func decode<T, Key: Hashable>(clazz clazz: [Key:T].Type, source: AnyObject) -> [Key:T] {
        let sourceDictionary = source as! [Key: AnyObject]
        var dictionary = [Key:T]()
        for (key, value) in sourceDictionary {
            dictionary[key] = Decoders.decode(clazz: T.self, source: value)
        }
        return dictionary
    }

    static func decode<T>(clazz clazz: T.Type, source: AnyObject) -> T {
        initialize()
        if T.self is Int32.Type && source is NSNumber {
            return source.intValue as! T;
        }
        if T.self is Int64.Type && source is NSNumber {
            return source.longLongValue as! T;
        }
        if T.self is NSUUID.Type && source is String {
            return NSUUID(UUIDString: source as! String) as! T
        }
        if source is T {
            return source as! T
        }
        if T.self is NSData.Type && source is String {
            return NSData(base64EncodedString: source as! String, options: NSDataBase64DecodingOptions()) as! T
        }

        let key = "\(T.self)"
        if let decoder = decoders[key] {
           return decoder(source) as! T
        } else {
            fatalError("Source \(source) is not convertible to type \(clazz): Maybe swagger file is insufficient")
        }
    }

    static func decodeOptional<T>(clazz clazz: T.Type, source: AnyObject?) -> T? {
        if source is NSNull {
            return nil
        }
        return source.map { (source: AnyObject) -> T in
            Decoders.decode(clazz: clazz, source: source)
        }
    }

    static func decodeOptional<T>(clazz clazz: [T].Type, source: AnyObject?) -> [T]? {
        if source is NSNull {
            return nil
        }
        return source.map { (someSource: AnyObject) -> [T] in
            Decoders.decode(clazz: clazz, source: someSource)
        }
    }

    static func decodeOptional<T, Key: Hashable>(clazz clazz: [Key:T].Type, source: AnyObject?) -> [Key:T]? {
        if source is NSNull {
            return nil
        }
        return source.map { (someSource: AnyObject) -> [Key:T] in
            Decoders.decode(clazz: clazz, source: someSource)
        }
    }

    static private func initialize() {
        dispatch_once(&once) {
            let formatters = [
                "yyyy-MM-dd",
                "yyyy-MM-dd'T'HH:mm:ssZZZZZ",
                "yyyy-MM-dd'T'HH:mm:ss.SSSZZZZZ",
                "yyyy-MM-dd'T'HH:mm:ss'Z'",
                "yyyy-MM-dd'T'HH:mm:ss.SSS"
            ].map { (format: String) -> NSDateFormatter in
                let formatter = NSDateFormatter()
                formatter.dateFormat = format
                return formatter
            }
            // Decoder for NSDate
            Decoders.addDecoder(clazz: NSDate.self) { (source: AnyObject) -> NSDate in
               if let sourceString = source as? String {
                    for formatter in formatters {
                        if let date = formatter.dateFromString(sourceString) {
                            return date
                        }
                    }

                }
                if let sourceInt = source as? Int {
                    // treat as a java date
                    return NSDate(timeIntervalSince1970: Double(sourceInt / 1000) )
                }
                fatalError("formatter failed to parse \(source)")
            } 

            // Decoder for [InventoryItem]
            Decoders.addDecoder(clazz: [InventoryItem].self) { (source: AnyObject) -> [InventoryItem] in
                return Decoders.decode(clazz: [InventoryItem].self, source: source)
            }
            // Decoder for InventoryItem
            Decoders.addDecoder(clazz: InventoryItem.self) { (source: AnyObject) -> InventoryItem in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = InventoryItem()
                instance.id = Decoders.decodeOptional(clazz: NSUUID.self, source: sourceDictionary["id"])
                instance.name = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["name"])
                instance.releaseDate = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["releaseDate"])
                instance.manufacturer = Decoders.decodeOptional(clazz: ManufacturerUp.self, source: sourceDictionary["manufacturer"])
                return instance
            }


            // Decoder for [ManufacturerUp]
            Decoders.addDecoder(clazz: [ManufacturerUp].self) { (source: AnyObject) -> [ManufacturerUp] in
                return Decoders.decode(clazz: [ManufacturerUp].self, source: source)
            }
            // Decoder for ManufacturerUp
            Decoders.addDecoder(clazz: ManufacturerUp.self) { (source: AnyObject) -> ManufacturerUp in
                let sourceDictionary = source as! [NSObject:AnyObject]
                let instance = ManufacturerUp()
                instance.name = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["name"])
                instance.homePage = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["homePage"])
                instance.phone = Decoders.decodeOptional(clazz: String.self, source: sourceDictionary["phone"])
                return instance
            }
        }
    }
}
